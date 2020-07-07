using BlueSite.Components;
using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Models;
using JobHunter.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class ActionsBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }

        protected string doneClass = "";
        protected string ActionKey = "";
        protected string ActionType = "research";

        protected Confirm confirm;
        protected NoteEdit noteEdit;
        protected NoteViewer noteviewer;
        protected Overlay overlay;

        protected IList<ActionItem> actions = new List<ActionItem>();
        protected string newAction;

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
            actions = getActionList();

            Options = new List<DDOption>();
            var opts = Actions.Types;
            foreach (var o in opts)
            {
                Options.Add(new DDOption(o.ActionTypeId, o.Name));
            }

            Statuses = new List<DDOption>();
            Statuses.Add(new DDOption("*", ""));
            Statuses.Add(new DDOption("todo", "To Do"));
            Statuses.Add(new DDOption("started", "Started"));
            Statuses.Add(new DDOption("waiting", "Waiting"));
            Statuses.Add(new DDOption("hold", "On Hold"));
            Statuses.Add(new DDOption("done", "Done"));
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
            int index = Convert.ToInt32(vals[0]);
            var t = actions[index];
            switch (vals[1])
            {
                case "done":
                    t.IsDone = (vals[2] == "1");
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

        protected void HandleSetActionType(string key)
        {
            ActionType = key.ToLower();
            actions = getActionList();
            newAction = string.Empty;
            StateHasChanged();
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
            return Actions.AllActions.Where(a => a.Type == ActionType).ToList();
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle", title);
        }

    }
}
