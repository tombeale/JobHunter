using BlueSite.Components;
using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Application;
using JobHunter.Models;
using JobHunter.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class CompaniesBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }


        protected List<Company>  companies;
        protected List<DDOption> phoneTypes;
        protected List<Contact> contacts;
        protected List<CompanyContactRelationship> contactRelationships;

        public AddRelationsshipDialog dialog;


        protected string hideContacts = "display: none;";

        protected CompaniesBase Self;

        JobHuntRepository Repository;


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
                    dialog.Hide();
                    break;
                case "cancel":
                    dialog.Hide();
                    break;
            }
        }

        protected void HandleSidebarOption(string key)
        {
            switch (key.ToLower())
            {
                case "togglecontacts":
                    if (hideContacts == "")
                    {
                        hideContacts = "display: none;";
                    }
                    else
                    {
                        hideContacts = "";
                    }
                    break;
            }
            StateHasChanged();
        }

        protected async void HandleRowExpand(string id)
        {
            await JsRuntime.InvokeVoidAsync(identifier: "toggleExpand", $"company-{id}");
        }

        /* *******************************************************************
            Startup Events
         ****************************************************************** */

        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);
            companies = GetCompanyList();
            contacts  = GetAllContacts();
            contactRelationships  = GetCompanyContactRelationships();
            Self = this;
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

        List<Contact> GetAllContacts()
        {
            return Repository.AllContacts.ToList();
        }
        List<CompanyContactRelationship> GetCompanyContactRelationships()
        {
            return Repository.GetCompanyContactRelationships().ToList();
        }

        protected void AddContactCallback(string value)
        {
            StateHasChanged();
        }

        protected List<Contact> GetContactsForCompany(int companyId)
        {
            var relationships = contactRelationships.Where(r => r.CompanyId == companyId).Select(c => c.ContactId).ToList();
            return contacts.Where(c => relationships.Contains(c.ContactId)).ToList();
        }



    }
}
