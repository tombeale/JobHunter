using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Application;
using JobHunter.Models;
using JobHunter.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
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

        protected List<Campaign> Campaigns  = new List<Campaign>();
        public List<DDOption>   ActionTypes = new List<DDOption>();
        public List<DDOption>   Statuses    = new List<DDOption>();
        public List<ActionItem> Actions     = new List<ActionItem>();

        protected string     NoteImage { get; set; }
        protected NoteEdit   noteEdit;
        protected NoteViewer noteviewer;
        protected Overlay    overlay;

        private User _user;


        protected StateList ListState;

        protected string hideCampaigns = "display: none;";
        JobHuntRepository       Repository;

        /* *******************************************************************
            Data
         ****************************************************************** */


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

        protected void HandleSidebarOption(string key)
        {
            switch (key.ToLower())
            {
                case "togglecampaigns":
                    if (hideCampaigns == "")
                    {
                        hideCampaigns = "display: none;";
                    }
                    else
                    {
                        hideCampaigns = "";
                    }
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

        /* *******************************************************************
            Life Cycle Events
         ****************************************************************** */
        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);
            Campaigns  = Repository.AllCampaigns.ToList();
            Actions    = Repository.GetAllCampaignActions();
            var stats  = Repository.GetStatuses();

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

            ListState = new StateList(Repository.GetUserPref(_user.UserId, "campaigns:liststate", ""));
        }


        protected override void OnParametersSet()
        {
            base.OnParametersSet();

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Campaign Management");
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
                title);
        }


    }
}
