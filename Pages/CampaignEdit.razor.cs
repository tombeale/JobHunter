using BlueSite.Data;
using BlueSite.Data.Entities;
using Microsoft.AspNetCore.Components;
using System;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using JobHunter.Application;
using JobHunter.Shared;
using JobHunter.Models;

namespace JobHunter.Pages
{
    public class CampaignEditBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter]
        public string Id { get; set; } = null;

        public Campaign Campaign { get; set; }
        JobHuntRepository Repository;

        protected string StatusMessage = "";
        protected string PageAction = "Edit";

        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);
        
            
        }


        /* *******************************************************************
            Startup Events
         ****************************************************************** */

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (Id != null)
            {
                int CampaignId = Convert.ToInt32(Id);
                Campaign = GetCampaign(CampaignId);
                PageAction = "Edit";
            }
            else
            {
                Campaign = new Campaign();
                PageAction = "Add";
            }
        }


        /* *******************************************************************
            Data Methods
         ****************************************************************** */

        public Campaign GetCampaign(int id)
        {
            Campaign campaign = Repository.GetCampaign(id);
            if (campaign != null)
            {
                
            }
            return campaign;
        }


        /* *******************************************************************
            Form-Related Methods
         ****************************************************************** */
        protected void HandleValidSubmit()
        {
            StatusMessage = "Saved";
            if (Campaign.CampaignId < 1)
            {
            }
            else
            {
            }
            StateHasChanged();
            _context.SaveChanges();
            NavManager.NavigateTo("/companies");
        }
        protected void HandleCancel()
        {
            NavManager.NavigateTo("/campaigns");
        }

    }
}