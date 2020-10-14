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
    public class MeetingViewBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter]
        public string MeetingId { get; set; }

        [Parameter]
        public string CompanyId { get; set; }

        [Parameter]
        public string FromPage { get; set; }

        bool Cancelled = false;
        public bool RefreshPage { get; set; } = false;

        protected string MeetingDate { get; set; }
        protected int ActionId { get; set; }
        protected ActionItem Action { get; set; }
        protected Company Company { get; set; }
        protected Models.Address CompanyAddress { get; set; }
        
        protected List<Topic> Topics;
        
        private QueryString Params;
        protected TopicSection topicSection;
        private JobHuntRepository Repository;
        private User _user;




        /* *******************************************************************
             Handlers
        ****************************************************************** */
        protected void HandleSidebarOption(string key)
        {
            switch (key.ToString())
            {
                case "viewcampaign":
                    NavManager.NavigateTo($"/campaigns/{Action.CampaignId}");
                    break;
                case "viewmeeting":
                    NavManager.NavigateTo($"/meetingview/{MeetingId}");
                    break;
                case "prepmeeting":
                    NavManager.NavigateTo($"/meetingprep/{MeetingId}");
                    break;
                case "editmeeting":
                    NavManager.NavigateTo($"/meetingprep/{MeetingId}");
                    break;
                case "editaction":
                    NavManager.NavigateTo($"/actionedit/{MeetingId}");
                    break;
            }
        } 


       /* *******************************************************************
            Life Cycle Events
         ****************************************************************** */
        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);
            _user = Repository.GetUserFromSignon();

            Params = new QueryString(NavManager.Uri);
            FromPage  = Params.Get("frompage");
            CompanyId = Params.Get("companyid");
            //ListState = new StateList(Repository.GetUserPref(_user.UserId, "campaigns:liststate", ""));
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            ActionId = Convert.ToInt32(MeetingId);
            Action = Repository.GetAction(ActionId);
            if (Action.CampaignId != null)
            {
                int cid = Convert.ToInt32(Action.CampaignId);
                Company = Repository.GetCompanyFromCampaignId(cid);
                CompanyAddress = (Company != null) ? Utilities.GetAddress<Company>(Company) : null;
            }
            Topics = Repository.GetTopicsForParentId("action", ActionId);

            MeetingDate = (Action.EndDate == null) ? "Not yet known" : Action.EndDate?.ToString("MMM d, yyyy");
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("View Meeting");
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle", title);
        }

    }
}
