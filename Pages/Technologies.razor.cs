using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Application;
using JobHunter.Models;
using JobHunter.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace JobHunter.Pages
{
    public class LanguagesBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter]
        public string MeetingId { get; set; }

        private JobHuntRepository Repository;
        protected List<LanguageEntry> Technologies = new List<LanguageEntry>();
        private User _user;

        protected LanguageEntry NewTech = new LanguageEntry();

        /* *******************************************************************
             Handlers
        ****************************************************************** */
        protected void HandleSidebarOption(string key)
        {
            switch (key.ToLower())
            {
                case "sortname":
                    LoadData("name");
                    break;
                case "sortnamedesc":
                    LoadData("namedesc");
                    break;
                case "sortyear":
                    LoadData("date");
                    break;
                case "sortyeardesc":
                    LoadData("datedesc");
                    break;
                case "export":
                    ExportToJson();
                    break;
            }
        }

        protected void HandleChildChange(string key)
        {
            StateHasChanged();
        }

        protected void ExportToJson()
        {
            Exporter exporter = new Exporter(_context);
            string path = Globals.TechExportPath;
            string result = exporter.ExportTech(path);
        }

        protected void LoadData(string sort = "name")
        {
            switch(sort.ToLower())
            {
                case "date":
                    Technologies = Repository.GetLanguages.OrderBy(f => f.BaseYear).ToList();
                    break;
                case "datedesc":
                    Technologies = Repository.GetLanguages.OrderByDescending(f => f.BaseYear).ToList();
                    break;
                case "namedesc":
                    Technologies = Repository.GetLanguages.OrderByDescending(f => f.Name).ToList();
                    break;
                default:
                    Technologies = Repository.GetLanguages.OrderBy(f => f.Name).ToList();
                    break;
            }
            StateHasChanged();
        }

        /* *******************************************************************
            Life Cycle Events
         ****************************************************************** */
        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);
            _user = Repository.GetUserFromSignon();
        }


        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            LoadData();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Manage Languages");
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
                title);
        }

    }
}
