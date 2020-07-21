using BlueSite.Components;
using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Models;
using JobHunter.Shared;
using JobHunter.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class ActionsBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        protected string doneClass = "";
        protected string ActionKey = "";
        protected string ActionType = "All";

        protected Confirm confirm;
        protected NoteEdit noteEdit;
        protected NoteViewer noteviewer;
        protected Overlay overlay;
        protected ActionStatus actionStatus;

        protected IList<ActionItem> actions = new List<ActionItem>();
        protected string newAction;

        private User _user;

        protected JobHuntRepository Actions;

        protected bool hideDone = true;

        protected List<DDOption> Options;
        protected List<DDOption> Statuses;

        /* =============================================
         *      Life Cycle Events
         * ===========================================*/

        protected override void OnInitialized()
        {
            Actions = new JobHuntRepository(_context);
            _user = Actions.GetUserFromSignon();
            ActionType = Actions.GetUserPref(_user.UserId, "actions:actiontype", ActionType);


            actions = getActionList();

            Options = new List<DDOption>();
            var opts = Actions.Types;
            foreach (var o in opts)
            {
                Options.Add(new DDOption(o.ActionTypeId, o.Name));
            }

            Statuses = Globals.GetActionStatuses();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Action Items");
        }

        /* =============================================
         *      Handlers
         * ===========================================*/

        protected void HandleDialogSelection(string key)
        {
            switch (key)
            {
                case "continue":
                    ConfirmDelete(key);
                    confirm.Hide();
                    break;
                case "cancel":
                    confirm.Hide();
                    break;
            }
        }

        protected void HandleSidebarOption(string key)
        {
            ActionKey = key;
            switch (key.ToLower())
            {
                case "toggledone":
                    hideDone = !hideDone;
                    break;
                case "deletedone":
                    confirm.Show();
                    break;
            }
            StateHasChanged();
        }

        public void HandleNoteSave(string value)
        {
            StateHasChanged();
        }

        protected void handleNewActionKeypress(KeyboardEventArgs args)
        {
            if (args.Key == "Enter")
            {
                AddAction();
            }
        }

        protected void HandleActionChange(string value)
        {
            var vals = value.Split('|');
            ActionItem t;
            int index = Convert.ToInt32(vals[0]);
            t = actions[index];
            switch (vals[1])
            {
                case "done":
                    t.IsDone = (vals[2] == "1");
                    break;
                case "status":
                    actionStatus.Show(index);
                    JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec|action-row-{index}");
                    break;
                case "title":
                    t.Title = vals[2];
                    break;
            }
            _context.SaveChanges();
            StateHasChanged();
        }

        protected void HandleRowOptionClick(string value)
        {
            var vals = value.Split('|');
            int index = Convert.ToInt32(vals[0]);
            var t = actions[index];
            switch (vals[1].ToLower())
            {
                case "add":
                    t.IsDone = false;
                    break;
                case "close":
                    t.IsDone = true;
                    StateHasChanged();
                    break;
                case "edit":
                    NavManager.NavigateTo($"/ActionEdit/{t.ActionItemId}");
                    break;
                case "note":
                case "note-filled":
                    if (t != null)
                    {
                        noteEdit.ActionItem = t;
                        noteEdit.Show(t);
                    }
                    break;
            }
        }

        protected void HandleSetActionStatus(string value)
        {
            string[] vals = value.Split('|');
            int index = Convert.ToInt32(vals[0]);
            var t = actions[index];
            t.Status = vals[1];
            _context.SaveChanges();
            StateHasChanged();
            JsRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec");
        }


        protected void HandleSetActionType(string key)
        {
            ActionType = key.ToLower();
            actions = getActionList();
            newAction = string.Empty;
            StateHasChanged();
            Actions.SaveUserPref(_user.UserId, "actions:actiontype", ActionType);
            _context.SaveChanges();
         }


        /* =============================================
         *      Supporting Methods
         * ===========================================*/

        protected void AddAction()
        {
            if (!string.IsNullOrWhiteSpace(newAction))
            {
                _context.Add(new ActionItem { Title = newAction, Type = ActionType });
                _context.SaveChanges();
                actions = getActionList();
                newAction = string.Empty;
            }
        }


        protected void ConfirmDelete(string key)
        {
            //todos.Where(t => t.IsDone).ToList().ForEach(t => _context.Remove(t));
            //_context.SaveChanges();
            //todos = getToDoList();
            //StateHasChanged();
            confirm.Hide();
        }

        List<ActionItem> getActionList()
        {
            if (ActionType != "*") { 
                return Actions.AllActions.Where(a => a.Type == ActionType).ToList();
            }
            else
            {
                return Actions.AllActions.ToList();
            }
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle", title);
        }

    }
}
