using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class CampaignViewBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter]
        public string CampaignId { get; set; }

        protected int campaignId;

        protected Campaign campaign;
        protected List<ActionItem> Actions;
        public List<DDOption> ActionTypes = new List<DDOption>();
        public List<DDOption> Statuses    = new List<DDOption>();

        protected string PageTitle = "";
        protected StateList ListState;

        private JobHuntRepository Repository;
        private User _user;

        protected LookUps lookups = new LookUps();

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
            _user      = Repository.GetUserFromSignon();
            var stats  = Repository.GetStatuses();
            foreach (var item in stats)
            {
                Statuses.Add(new DDOption(item.Key, item.Name));
            }
            var actionTypes = Repository.GetActionTypes();
            foreach (var item in actionTypes)
            {
                ActionTypes.Add(new DDOption(item.ActionTypeId, item.Name));
            }

            lookups.ActionTypes = ActionTypes;
            lookups.Statuses = Statuses;

            ListState = new StateList(Repository.GetUserPref(_user.UserId, "campaigns:liststate", ""));
        }


        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            campaignId = Convert.ToInt32(CampaignId);
            campaign   = Repository.GetCampaign(campaignId);
            Actions    = Repository.GetActionsForCampaign(campaignId).ToList();
            PageTitle  = campaign.Name;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("View Campaign");
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
                title);
        }

    }
}