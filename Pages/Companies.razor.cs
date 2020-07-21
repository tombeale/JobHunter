﻿using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Application;
using JobHunter.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class CompaniesBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }

        protected List<Company> companies;
        protected List<DDOption> phoneTypes;

        JobHuntRepository Repository;










        /* *******************************************************************
            Startup Events
         ****************************************************************** */

        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);
            companies = GetCompanyList();

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await SetTitle("Companies");
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            phoneTypes = Utilities.GetPhoneTypeLookup(Repository.GetPhoneTypes());
        }

        async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
                title);
        }


        /* *******************************************************************
            Data MEthods
         ****************************************************************** */

        List<Company> GetCompanyList()
        {
            return Repository.AllCompanies;
        }


    }
}
