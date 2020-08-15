using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Models;
using JobHunter.Services;
using JobHunter.Shared;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Shared
{
    public class NoteEditBase : ComponentBase
    {
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] BrowserService _browser { get; set; }

        [Parameter]
        public EventCallback<string> OnChangeCallback { get; set; }

        [Parameter]
        public string Buttons { get; set; } = "Cancel:cancel:btn btn-sm btn-secondary bs-dialog,Save:save:btn btn-sm btn-primary bs-dialog";

        [Parameter]
        public Overlay overlay { get; set; }

        [Parameter]
        public string NoteText { get; set; } = "";

        [Parameter]
        public int NoteId { get; set; } = -1;

        protected List<ButtonDef> buttons = new List<ButtonDef>();

        protected string hidden = "display: none;";
        protected string Title = "";
        protected NoteViewer noteviewer;

        private JobHuntRepository Repository;

        public ActionItem ActionItem { get; set; }

        protected void HandleButtonClick(string value)
        {
            switch (value.ToLower())
            {
                case "cancel":
                    Hide();
                    break;

                case "save":
                    if (NoteId < 0)
                    {
                        AddNote();
                    }
                    else
                    {
                        UpdateNote();
                    }
                    OnChangeCallback.InvokeAsync("Done");
                    break;
            }
        }


        public bool Load(int ActionId, int? NoteId)
        {
            bool success = false;


            return success;
        }

        public void Hide()
        {
            hidden = "display: none; ";
            if (overlay != null) overlay.Hide();
            StateHasChanged();
        }

        public void Show(ActionItem ai)
        {
            String actionText = (ActionItem.Title.Length < 43) ? ActionItem.Title : $"{ActionItem.Title.Substring(0, 40)}...";
            Title = $"Notes for: {actionText}";
            NoteText = "";
            hidden = "";
            if (overlay != null) overlay.Show();
            noteviewer.Load(ActionItem.Notes.OrderByDescending(f => f.TimeStamp).ToList());
            StateHasChanged();
        }

        private string AddNote()
        {
            Note note = new Note
            {
                User = "Tom",
                Type = "test",
                Text = NoteText
            };

            string result = Repository.AddNote(ActionItem.ActionItemId ?? 0, note);
            Hide();

            return result;
        }

        private string UpdateNote()
        {
            string result = "";


            return result;
        }

        // ================== Lifecycle Methods


        protected override void OnParametersSet()
        {
            Repository = new JobHuntRepository(_context);

            base.OnParametersSet();
            var btns = Buttons.Split(',');
            buttons.Clear();
            for (int i = 0; i < btns.Length; i++)
            {
                buttons.Add(new ButtonDef(btns[i]));
            }
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
           // _ = _browser.CenterElement();
            return _browser.CenterElement();
        }
    }
}
