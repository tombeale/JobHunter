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
    public class MeetingPrepBase : ComponentBase
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

        }

        protected void HandleDateChange(string datetime)
        {
            if (datetime != null && datetime.Length > 1)
            {
                var dt = Convert.ToDateTime(datetime);
                if (dt != null)
                {
                    Action.EndDate = dt;
                    _context.SaveChanges();
                }
            }
        }

        protected void HandleTopicChanged()
        {
            _context.SaveChanges();
            NavManager.NavigateTo(NavManager.Uri,true);
            //topicSection.ReloadTopicPoints();
            //StateHasChanged();
        }
        void HandlePointChange(string value)
        {
            string[] v = value.Split('|');


            if (v[0] == "N")
            {
                //await HandleTopicChange.InvokeAsync(value);
            }
            else
            {
                int index = Convert.ToInt32(v[1]);
                BlueSite.Data.Entities.TopicPoint point = topicSection.Topic.Topics[index];
                if (point != null)
                {
                    point.Text = value;
                    //await HandleTopicChange.InvokeAsync(value);
                }
            }
        }


        /* *******************************************************************
            Form-Related Methods
         ****************************************************************** */
        protected void HandleValidSubmit()
        {
            if (Cancelled)
            {
                Cancelled = false;
                return;
            }
        }
        protected void HandleCancel()
        {
            Cancelled = true;
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
            if (!String.IsNullOrEmpty(CompanyId))
            {
                int cid = Convert.ToInt32(CompanyId);
                Company = Repository.GetCompany(cid);
                CompanyAddress = Utilities.GetAddress<Company>(Company);

            }
            Topics = Repository.GetTopicsForParentId("action", ActionId);

            MeetingDate = (Action.EndDate == null) ? "Not yet known" : Action.EndDate?.ToString("MMM d, yyyy");
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Meeting Preparation");
        }

        protected async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle", title);
        }

    }
}
