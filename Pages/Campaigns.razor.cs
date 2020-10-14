using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Application;
using JobHunter.Models;
using JobHunter.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class CampaignsBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter]
        public string BaseCampaignId { get; set; } = "0";
        protected int _BaseCampaignId { get; set; } = 0;

        protected List<Campaign> AllCampaigns = new List<Campaign>();
        protected List<Campaign> Campaigns    = new List<Campaign>();
        protected List<Contact>  Contacts     = new List<Contact>();
        protected List<Company>  Companies    = new List<Company>();
        public List<DDOption>    ContactsList = new List<DDOption>();
        public List<DDOption>    ActionTypes  = new List<DDOption>();
        public List<DDOption>    Statuses     = new List<DDOption>();
        public List<ActionItem>  Actions      = new List<ActionItem>();

        protected List<Contact>  RelatedContacts        = new List<Contact>();
        public List<CampaignContactRelationship>  CCRs  = new List<CampaignContactRelationship>();

        protected string      NoteImage { get; set; }
        protected ContactList contactList;
        protected NoteEdit    noteEdit;
        protected NoteViewer  noteviewer;
        protected Overlay     overlay;

        protected List<string> Exclude = new List<string>() { "nogo", "cancelled", "expired", "done" };
        protected bool ShowAll = false;

        private User _user;


        protected StateList ListState;

        protected string hideCampaigns = "display: none;";
        JobHuntRepository       Repository;


        /* *******************************************************************
            Handlers
         ****************************************************************** */

        protected void HandleActionClick(string value)
        {
            var vals = value.Split('|');
            int? id = Convert.ToInt32(vals[0]);
            var action = Actions.Where(a => a.ActionItemId == id).FirstOrDefault();
            switch (vals[1].ToLower())
            {
                case "edit":
                    NavManager.NavigateTo($"/actionedit/{action.ActionItemId}?frompage=campaigns");
                    break;
                case "note":
                case "note-filled":
                    if (action != null)
                    {
                        noteEdit.ActionItem = action;
                        noteEdit.Show(action);
                    }
                    break;
            }
        }

        public void HandleNoteSave(string value)
        {
            StateHasChanged();
        }

        public void HandleLinkRequest(string value)
        {
            string[] args = value.Split('|');
            var vals = value.Split('|');
            ActionItem t;
            int id = Convert.ToInt32(vals[1]);
            contactList.Show(id);
            JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"contact-list-sec|add-{vals[0]}-{vals[1]}");
        }

        protected void HandleOpenCloseClick(int id)
        {

        }

        protected void HandleDialogSelection(string key)
        {
            switch (key)
            {
                case "add":
                    //dialog.Hide();
                    break;
                case "cancel":
                    //dialog.Hide();
                    break;
            }
        }

        protected async void HandleRowExpand(string id)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "toggleExpand", $"campaign-{id}");
        }

        protected void HandleLinkContact(string value)
        {
            var vals = value.Split('|');
            int CampaignId = Convert.ToInt32(vals[0]);
            int ContactId  = Convert.ToInt32(vals[1]);
            var ccr = Repository.GetCampaignContactRelationship(CampaignId, ContactId);
            if (ccr == null)
            {
                ccr = new CampaignContactRelationship();
                ccr.CampaignId = CampaignId;
                ccr.ContactId  = ContactId;
                _context.CampaignContactRelationships.Add(ccr);
                _context.SaveChanges();
            }
            StateHasChanged();
        }

        protected void HandleSidebarOption(string key)
        {
            switch (key.ToLower())
            {
                case "toggle-all":
                    ShowAll = !ShowAll;
                    break;
                case "collapse-all":
                    ListState.CloseAll();
                    Repository.SaveUserPref(_user.UserId, "campaigns:liststate", ListState.ToString());
                    break;
            }
            StateHasChanged();
        }

        protected void HandleRowOptionClick(string value)
        {
            var vals = value.Split('|');
            int index = Convert.ToInt32(vals[0]);
            Campaign c = Campaigns[index];
            switch (vals[1].ToLower())
            {
                case "edit":
                    NavManager.NavigateTo($"/campaignedit/{c.CampaignId}");
                    break;
                case "action":
                    ListState.Toggle(c.CampaignId, "actions");
                    Repository.SaveUserPref(_user.UserId, "campaigns:liststate", ListState.ToString());
                    StateHasChanged();
                    break;
                case "person":
                    ListState.Toggle(c.CampaignId, "contacts");
                    Repository.SaveUserPref(_user.UserId, "campaigns:liststate", ListState.ToString());
                    StateHasChanged();
                    break;
                case "note":
                case "note-filled":
                    ListState.Toggle(c.CampaignId, "notes");
                    Repository.SaveUserPref(_user.UserId, "campaigns:liststate", ListState.ToString());
                    StateHasChanged();
                    break;
            }
        }

        protected void HandleSectionClick(string value)
        {
            var vals = value.Split('|');
            int campaignId = Convert.ToInt32(vals[0]);
            switch (vals[1].ToLower())
            {
                case "action":
                    ListState.Toggle(campaignId, "actions");
                    break;
                case "contact":
                    ListState.Toggle(campaignId, "contacts");
                    break;
                case "note":
                    ListState.Toggle(campaignId, "note");
                    break;
                default:
                    return;
            }
            Repository.SaveUserPref(_user.UserId, "campaigns:liststate", ListState.ToString());
            StateHasChanged();
        }

        protected void EditContact(int contactId)
        {
            NavManager.NavigateTo($"/contactedit/{contactId}");
        }

        /* *******************************************************************
            Life Cycle Events
         ****************************************************************** */
        protected override void OnInitialized()
        {
            Repository    = new JobHuntRepository(_context);
            Contacts      = Repository.AllContacts.ToList();
            Companies     = Repository.AllCompanies.ToList();
            AllCampaigns  = Repository.AllCampaigns.ToList();
            Actions       = Repository.GetAllCampaignActions();
            CCRs          = _context.CampaignContactRelationships.ToList();
            var stats     = Repository.GetStatuses();

            RelatedContacts = Repository.GetAllCampaignContacts();

            _user = Repository.GetUserFromSignon();

            foreach (var item in stats)
            {
                Statuses.Add(new DDOption(item.Key, item.Name));
            }

            var actionTypes = Repository.GetActionTypes();

            foreach (var item in actionTypes)
            {
                ActionTypes.Add(new DDOption(item.ActionTypeId, item.Name));
            }

            foreach (var contact in Contacts)
            {
                string name;
                if (!String.IsNullOrEmpty(contact.FirstName) && !String.IsNullOrEmpty(contact.LastName)) {
                    name = $"{contact.LastName}, {contact.FirstName}";
                }
                else if (!String.IsNullOrEmpty(contact.FirstName))
                {
                    name = contact.FirstName;
                }
                else if (!String.IsNullOrEmpty(contact.LastName))
                {
                    name = contact.LastName;
                }
                else
                {
                    continue;
                }
                ContactsList.Add(new DDOption(contact.ContactId.ToString(), name));
            }

            ListState = new StateList(Repository.GetUserPref(_user.UserId, "campaigns:liststate", ""));
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            _BaseCampaignId = Convert.ToInt32(BaseCampaignId);

            if (_BaseCampaignId > 0)
            {
                Campaigns  = AllCampaigns.Where(c => c.CampaignId == _BaseCampaignId).ToList();
            }
            else
            {
                Campaigns  = AllCampaigns;
            }
        }

        protected void ToggleDetails(int id)
        {
            ListState.ToggleDetails(id);
            Repository.SaveUserPref(_user.UserId, "campaigns:liststate", ListState.ToString());
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Campaigns");
        }

        protected string GetCompanyName(int? companyId)
        {
            if (companyId != null)
            {
                return Repository.AllCompanies.Where(c => c.CompanyId == companyId).FirstOrDefault()?.Name;
            }
            else
            {
                return "";
            }
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
                title);
        }

        protected bool IsReletedContact(int contactId, int campaignId)
        {
            return CCRs.Any(c => c.CampaignId == campaignId && c.ContactId == contactId);
        }

    }
}
