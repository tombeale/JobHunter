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
        public List<DDOption> Companies = new List<DDOption>();
        public List<DDOption> Statuses  = new List<DDOption>();
        JobHuntRepository Repository;

        protected string StatusMessage = "";
        protected string PageAction = "Edit";
        protected bool Cancelled = false;

        /* *******************************************************************
            Startup Events
         ****************************************************************** */

        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);
            Companies.Add(new DDOption("", ""));
            var list = Repository.AllCompanies.OrderBy(c => c.Name).ToList();
            foreach (var item in list)
            {
                if (item.Name != null) Companies.Add(new DDOption(item.CompanyId.ToString(), item.Name));
            }

            var stats = Repository.GetStatuses();
            foreach (var item in stats)
            {
                Statuses.Add(new DDOption(item.Key, item.Name));
            }
        }


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
                Campaign.StartDate = DateTime.Now;
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
            Handlers
         ****************************************************************** */

        protected int? CompanyProxy
        {
            get
            {
                return Campaign.CompanyId;
            }
            set
            {
                Campaign.CompanyId = Convert.ToInt32(value);
                StateHasChanged();
            }
        }

        protected string StatusProxy
        {
            get
            {
                return Campaign.Status;
            }
            set
            {
                Campaign.Status = value;
                StateHasChanged();
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
            if (Campaign.CampaignId < 1)
            {
                if (Campaign.Name != null && Campaign.CompanyId != null)
                {
                    StatusMessage = "Saved";
                    _context.Campaigns.Add(Campaign);
                    StateHasChanged();
                    _context.SaveChanges();
                    NavManager.NavigateTo("/campaigns");
                }
                else
                {
                    StatusMessage = "Unable to Save: the Name and Company are required fields";
                }
            }
            else
            {
                StateHasChanged();
                _context.SaveChanges();
                NavManager.NavigateTo("/campaigns");
            }
        }
        protected void HandleCancel()
        {
            
            Cancelled = true;
            NavManager.NavigateTo("/campaigns", true);
        }

    }
}