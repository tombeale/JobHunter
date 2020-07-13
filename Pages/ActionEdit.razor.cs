using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Application;
using JobHunter.Models;
using JobHunter.Shared;
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

        [Parameter]
        public string actId { get; set; } = null;

        protected ActionItem Action;
        private int ActionId;

        public string PageTitle   = "Create New Action";
        public string HeaderTitle = "Create New Action";

        protected List<DDOption> ActionTypes;
        protected List<DDOption> ActionSetIds;
        protected List<DDOption> Statuses;

        protected SelectListing actionTypeList;
        protected SelectListing actionSetIdList;

        protected string StatusMessage = "";

        protected JobHuntRepository Actions;

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
                ActionTypes.Add(new DDOption(o.ActionTypeId, o.Name));
            }

            ActionSetIds = new List<DDOption>();
            var setIds = Actions.GetActionSetIdList();
            foreach (var s in setIds)
            {
                ActionSetIds.Add(new DDOption(s, s));
            }

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
            }
            else
            {
                Action      = Actions.GetAction(ActionId);
                PageTitle   = $"Editing Action: '{Action.Title}'";
                HeaderTitle = $"Editing Action";
            }
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Action Items");
        }

        /* *******************************************************************
            Data Methods
         ****************************************************************** */

        protected void HandleValidSubmit()
        {
            StatusMessage = "Valid Submit";
            StateHasChanged();
            _context.SaveChanges();
        }

        protected void HandleInvalidSubmit()
        {
            StatusMessage = "Invalid Submit";
            StateHasChanged();
        }

        /* *******************************************************************
            Form-Related Methods
         ****************************************************************** */
        public bool validateForm()
        {
            if (Action != null)
            {

            }
            return true;
        }


        /* *******************************************************************
            Handlers
         ****************************************************************** */

        protected void HandleActionTypeClick()
        {
            actionTypeList.Show();
            JSRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-1|action-type");
        }

        protected void HandleActionSetIdClick()
        {
            actionTypeList.Show();
            JSRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-2|action-set-id");
        }


        protected void HandleSetActionType(string value)
        {
            Action.Type = value;
            StateHasChanged();
            JSRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec-1");
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
    }
}
