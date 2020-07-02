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
    public class ToDoBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }

        protected IList<ActionItem> todos = new List<ActionItem>();
        protected string newTodo;

        protected string doneClass = "";
        protected string ActionKey = "";
        protected string ActionType = "todo";

        protected JobHuntRepository Actions;

        protected bool hideDone = true;

        protected List<DDOption> Options;
        protected List<DDOption> Statuses;


        protected IEnumerable<ActionItem> data;

        SideBar SideBar1 = new SideBar();

        protected Confirm confirm;
        protected NoteEdit noteEdit;
        protected NoteViewer noteviewer;
        protected Overlay overlay;

        protected void ItemHandler(int index)
        {
            var todo = todos[index];

        }

        protected void HandleRowOptionClick(string value)
        {
            var vals = value.Split('|');
            int index = Convert.ToInt32(vals[0]);
            var t = todos[index];
            switch (vals[1].ToLower())
            {
                case "note":
                    if (t != null)
                    {
                        noteEdit.ActionItem = t;
                        noteEdit.Show(t);
                    }
                    break;
                case "note-filled":
                    if (t != null)
                    {
                        noteviewer.Show(t.Notes.ToList());
                    }
                    break;
            }

        }

        public void HandleNoteSave(string value)
        {
            StateHasChanged();
        }

        protected void HandleActionChange(string value)
        {
            var vals = value.Split('|');
            int index = Convert.ToInt32(vals[0]);
            var t = todos[index];
            switch (vals[1]) { 
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

        protected void CheckedClicked(int index, bool b)
        {
            var t = todos[index];
            if (t != null && t.ActionItemId != null)
            {
                t.IsDone = b;
                _context.SaveChanges();
            }
        }

        protected void CaptionChanged(int index, string text)
        {
            var t = todos[index];
            if (t != null && t.ActionItemId != null)
            {
                t.Title = text;
                _context.SaveChanges();
            }
        }

        protected void handleNewTodoKeypress(KeyboardEventArgs args)
        {
            if (args.Key == "Enter")
            {
                AddTodo();
            }
        }


        protected void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                _context.Add(new ActionItem { Title = newTodo, Type = ActionType });
                _context.SaveChanges();
                todos = getToDoList();
                newTodo = string.Empty;
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

        protected void HandleSetActionType(string key)
        {
            ActionType = key.ToLower();
            todos = getToDoList();
            newTodo = string.Empty;
            StateHasChanged();
        }


        protected void HandleSetStatusFilter(string key)
        {
            string status = key.ToLower();
            todos = getToDoList();
            newTodo = string.Empty;
            StateHasChanged();
        }


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

        protected string HandleRowChange()
        {
            StateHasChanged();
            return "";
        }


        protected void ConfirmDelete(string key)
        {
            todos.Where(t => t.IsDone).ToList().ForEach(t => _context.Remove(t));
            _context.SaveChanges();
            todos = getToDoList();
            StateHasChanged();
            confirm.Hide();
        }

        protected override void OnInitialized()
        {
            Actions = new JobHuntRepository(_context);
            todos = getToDoList();

            Options = new List<DDOption>();
            var opts = Actions.Types;
            foreach (var o in opts)
            {
                Options.Add(new DDOption(o.ActionTypeId, o.Name));
            }

            Statuses = new List<DDOption>();
            Statuses.Add(new DDOption("*", ""));
            Statuses.Add(new DDOption("", "To Do"));
            Statuses.Add(new DDOption("started", "Started"));
            Statuses.Add(new DDOption("waiting", "Waiting"));
            Statuses.Add(new DDOption("hold", "On Hold"));
            Statuses.Add(new DDOption("done", "Done"));
        }

        List<ActionItem> getToDoList()
        {
            return Actions.AllActions.Where(a => a.Type == ActionType).ToList();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Actions");
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
                title);
        }
    }
}
