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
    public class CompanyEditBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }


        [Parameter]
        public string Id { get; set; } = null;

        public Company Company;
        public Phone   NewPhone = new Phone();

        protected SelectListing companyTypeList;
        protected SelectListing companyInterestList;
        protected SelectListing phoneTypeList;

        
        JobHuntRepository Repository;
        protected List<DDOption> CompanyTypes;
        protected List<DDOption> PhoneTypes;
        protected List<DDOption> CompanyIntrests;

        protected List<Phone> Phones;

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

            PhoneTypes = new List<DDOption>();
            var phoneTypes = Repository.GetPhoneTypes();
            foreach (var pt in phoneTypes)
            {
                if (pt != null) PhoneTypes.Add(new DDOption(pt.Type, pt.Name));
            }
        }

        /* *******************************************************************
            Startup Events
         ****************************************************************** */

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
            Company company = Repository.GetCompany(id);
            if (company != null && company.Phones == null)
            {
                company.Phones = Repository.GetPhonesForCompany(id);
            }
            return company;
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

        protected void HandlePhoneTypeClick()
        {
            phoneTypeList.Show();
            if (Globals.CurrentPhoneIndex >= 0)
            {
                string index = Globals.CurrentPhoneIndex.ToString();
                JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-3|phone-type-{index}");
            }
            else
            {
                JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-3|phone-type-new");
            }
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

        public void HandleSetPhoneType(string value)
        {
            if (Globals.CurrentPhoneIndex < 0)
            {
                NewPhone.Type = value;
            }
            else
            {
                Company.Phones[Globals.CurrentPhoneIndex].Type = value;
            }
            
            Globals.CurrentPhoneIndex = -1;
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
            else
            {
                if (!String.IsNullOrWhiteSpace(NewPhone.Number) && !String.IsNullOrWhiteSpace(NewPhone.Type))
                {
                    NewPhone.CompanyId = Company.CompanyId;

                    if (Company.Phones == null)
                    {
                        Company.Phones = new List<Phone>();
                    }

                    Company.Phones.Add(NewPhone);
                }
            }
            StateHasChanged();
            _context.SaveChanges();
            NewPhone = new Phone();
            NavManager.NavigateTo("/companies");
        }

        protected void HandleInvalidSubmit()
        {
            StatusMessage = "There was an error submitting the form";
        }

        public void validateForm()
        {
            if (Company != null)
            {

            }
        }

    }
}
