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
    public class CampaignsBase : ComponentBase
    {
        protected List<Campaign> Campaigns = new List<Campaign>();

        /* *******************************************************************
            Handlers
         ****************************************************************** */

        protected void OnClickCallback(string key)
        {
        }

        protected void HandleDialogSelection(string key)
        {
            switch (key)
            {
                case "add":
                    //dialog.Hide();
                    break;
                case "cancel":
                    //dialog.Hide();
                    break;
            }
        }

        protected void HandleSidebarOption(string key)
        {
            switch (key.ToLower())
            {
                case "togglecontacts":
                    break;
            }
            StateHasChanged();
        }



    }
}
