using BlueSite.Data;
using BlueSite.Data.Entities;
using Microsoft.AspNetCore.Components;
using System;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobHunter.Shared;
using JobHunter.Models;

namespace JobHunter.Pages
{
    public class CompanyEditBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }


        [Parameter]
        public string Id { get; set; } = null;

        public Company Company;

        protected SelectListing companyTypeList;
        protected SelectListing companyInterestList;

        
        JobHuntRepository Repository;
        protected List<DDOption> CompanyTypes;
        protected List<DDOption> CompanyIntrests;

        protected string StatusMessage = "";

        /* *******************************************************************
            Startup Events
        ******************************************************************* */

        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);

            CompanyTypes = new List<DDOption>();
            var types = Repository.GetCompanyTypes();
            foreach (var t in types)
            {
                if (t != null) CompanyTypes.Add(new DDOption(t.CompanyTypeId, t.Name));
            }

            CompanyIntrests = new List<DDOption>();
            var intrests = Repository.GetCompanyIntrests();
            foreach (var ci in intrests)
            {
                if (ci != null) CompanyIntrests.Add(new DDOption(ci.CompanyInterestId, ci.Name));
            }
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (Id != null)
            {
                int CompanyId = Convert.ToInt32(Id);
                Company = GetCompany(CompanyId);
            }
            else
            {
                Company = new Company();
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (Id != null)
            {
                await SetTitle($"Viewing Company Id #{Company.CompanyId}");
            }
            else
            {
                await SetTitle($"Adding New Company");
            }
        }

        async Task SetTitle(string title)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "setTitle",
                title);
        }


        /* *******************************************************************
            Data Methods
         ****************************************************************** */

        public Company GetCompany(int id)
        {
            return Repository.GetCompany(id);
        }

        /* *******************************************************************
            Handlers
         ****************************************************************** */

        protected void HandleCompanyTypeClick()
        {
            companyTypeList.Show();
            JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-1|company-type");
        }

        protected void HandleCompanyInterestClick()
        {
            companyInterestList.Show();
            JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-2|company-interest");
        }

        public void HandleSetCompanyType(string value)
        {
            Company.Type = value;
            StateHasChanged();
            JsRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec-1");
        }

        public void HandleSetCompanyInterest(string value)
        {
            Company.Interest = value;
            StateHasChanged();
            JsRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec-2");
        }


        /* *******************************************************************
            Form-Related Methods
         ****************************************************************** */
        protected void HandleValidSubmit()
        {
            StatusMessage = "Saved";
            if (Company.CompanyId < 1)
            {
                _context.Companies.Add(Company);
            }
            StateHasChanged();
            _context.SaveChanges();
        }

        public void validateForm()
        {
            if (Company != null)
            {

            }
        }

    }
}
