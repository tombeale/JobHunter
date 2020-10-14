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
    public class ResumeBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter]
        public string MeetingId { get; set; }


        private JobHuntRepository Repository;
        private User _user;


        /* *******************************************************************
             Handlers
        ****************************************************************** */
        protected void HandleSidebarOption(string key)
        {

        }

        /* *******************************************************************
            Life Cycle Events
         ****************************************************************** */
        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);
            _user = Repository.GetUserFromSignon();
            //ListState = new StateList(Repository.GetUserPref(_user.UserId, "campaigns:liststate", ""));
        }


        protected override void OnParametersSet()
        {
            base.OnParametersSet();

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Manage Resume");
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
                title);
        }

    }
}
