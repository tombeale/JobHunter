using BlueSite.Data;
using BlueSite.Data.Entities;
using BlueSite.Data.Migrations;
using JobHunter.Application;
using JobHunter.Models;
using JobHunter.Shared;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class ActionEditBase : ComponentBase
    {
        [Inject] IJSRuntime JSRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter]
        public string actId { get; set; } = null;

        protected string ActionSet = "actionedit";

        public string FromPage { get; set; } = null;
        public string RelationshipType { get; set; } = null;
        public string RelationshipId { get; set; } = null;

        protected ActionItem Action;
        private int ActionId;

        public string PageTitle   = "Create New Action";
        public string HeaderTitle = "Create New Action";

        protected List<DDOption> ActionTypes;
        protected List<DDOption> ActionSetIds;
        protected List<DDOption> Statuses;

        protected SelectListing actionTypeList;
        protected SelectListing actionStatusList;
        protected SelectListing actionSetIdList;
        protected SelectListing actionProjectList;

        protected string StatusMessage = "";

        protected JobHuntRepository Actions;

        private bool canceled = false;

        private QueryString Params;

        /* *******************************************************************
            Life-Cycle Handlers
         ****************************************************************** */
        protected override void OnInitialized()
        {
            Actions = new JobHuntRepository(_context);

            ActionTypes = new List<DDOption>();
            var opts = Actions.Types;
            foreach (var o in opts)
            {
                if (o != null) ActionTypes.Add(new DDOption(o.ActionTypeId, o.Name));
            }

            ActionSetIds = new List<DDOption>();
            var setIds = Actions.GetActionSetIdList();
            foreach (var setId in setIds)
            {
                if (setId != null) ActionSetIds.Add(new DDOption(setId.SetId, setId.Name));
            }

            Params = new QueryString(NavManager.Uri);
            FromPage         = Params.Get("frompage");
            RelationshipType = Params.Get("reltype");
            RelationshipId   = Params.Get("relid");

            Statuses = Globals.GetActionStatuses();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            Actions = new JobHuntRepository(_context);

            ActionId = Convert.ToInt32(actId);

            if (actId == null)
            {
                Action = new ActionItem();
                Action.StartDate = DateTime.Now;
                PageTitle   = $"Add New Action";
                HeaderTitle = $"Add New Action";
            }
            else
            {
                Action      = Actions.GetAction(ActionId);
                PageTitle   = $"Editing Action: '{Action.Title}'";
                HeaderTitle = $"Editing Action";
                ActionSet   = "editmeeting";
            }
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Action Items");
        }

        /* *******************************************************************
            Form Submission Methods
         ****************************************************************** */

        protected void HandleValidSubmit()
        {
            if (Action != null)
            {
                if (!canceled)
                {
                    if (!String.IsNullOrEmpty(RelationshipType) && !String.IsNullOrEmpty(RelationshipId))
                    {
                        int relId = Convert.ToInt32(RelationshipId);
                        switch (RelationshipType.ToLower())
                        {
                            case "campaign":
                                Action.CampaignId = relId;
                                break;
                        }
                    }
                    if (Action.ActionItemId == null)
                    {
                        _context.ActionItems.Add(Action);
                    }
                    _context.SaveChanges();
                    StateHasChanged();
                    canceled = false;
                    StatusMessage = "Saved";
                }
                Redirect();
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusMessage = "There was a problem saving the form";
            StateHasChanged();
        }

        protected void HandleCancel()
        {
            canceled = true;
            Redirect();
        }
        protected void Redirect()
        {
            switch (FromPage)
            {
                case "campaigns":
                    NavManager.NavigateTo("/campaigns", true);
                    break;
                default:
                    NavManager.NavigateTo("/actions", true);
                    break;
            }
        }


        /* *******************************************************************
            Form-Related Methods
         ****************************************************************** */
        public bool validateForm()
        {
            return true;
        }

        /* *******************************************************************
            Handlers
         ****************************************************************** */

        protected void HandleActionStatusClick()
        {
            actionTypeList.Show();
            JSRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-3|action-status");
        }

        protected void HandleActionTypeClick()
        {
            actionTypeList.Show();
            JSRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-1|action-type");
        }

        protected void HandleDoneClicked(string value)
        {
            Action.IsDone = (value == "1");
            StateHasChanged();
        }

        protected void HandleActionSetIdClick()
        {
            actionTypeList.Show();
            JSRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-2|action-set-id");
        }

        protected void HandleActionProjectIdClick()
        {
            actionTypeList.Show();
            JSRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-3|action-project-id");
        }


        protected void HandleSetActionType(string value)
        {
            Action.Type = value;
            StateHasChanged();
            JSRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec-1");
        }

        protected void HandleSetActionStatus(string value)
        {
            Action.Status = value;
            StateHasChanged();
            JSRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec-3");
        }

        protected void HandleSetActionSetId(string value)
        {
            Action.SetId = value;
            StateHasChanged();
            JSRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec-2");
        }

        protected async Task SetTitle(string title)
        {
            await JSRuntime.InvokeVoidAsync(identifier: "setTitle", title);
        }

        protected void HandleSidebarOption(string key)
        {
            switch (key.ToString())
            {
                case "viewmeeting":
                    NavManager.NavigateTo($"/meetingview/{Action.ActionItemId}");
                    break;
                case "prepmeeting":
                    NavManager.NavigateTo($"/meetingprep/{Action.ActionItemId}");
                    break;
                case "editaction":
                    NavManager.NavigateTo($"/actionedit/{Action.ActionItemId}");
                    break;
            }
        } 
    }
}
