using BlueSite.Components;
using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Application;
using JobHunter.Models;
using JobHunter.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class ContactEditBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }
        [Inject] NavigationManager NavManager { get; set; }

        [Parameter]
        public string contactId { get; set; } = null;

        [Parameter]
        public string FromPage { get; set; } = "";

        //[Parameter]
        public bool IsPartial { get; set; } = false;

        [Parameter]
        public AddRelationsshipDialog ParentDialog { get; set; } = null;

        protected Contact Contact;

        public Phone NewPhone = new Phone();
        protected SelectListing phoneTypeList;
        protected List<DDOption> PhoneTypes;

        private int CompanyId = -1;

        JobHuntRepository Repository;

        protected string StatusMessage = "";

        /* *******************************************************************
            Startup Events
        ******************************************************************* */

        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);

            PhoneTypes = new List<DDOption>();
            NewPhone.Type = "work";
            var phoneTypes = Repository.GetPhoneTypes();
            foreach (var pt in phoneTypes)
            {
                if (pt != null) PhoneTypes.Add(new DDOption(pt.Type, pt.Name));
            }
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            if (contactId != null)
            {
                int CompanyId = Convert.ToInt32(contactId);
                Contact = GetContact(CompanyId);
            }
            else
            {
                Contact = new Contact();
            }

            IsPartial = (FromPage != "");

        }



        /* *******************************************************************
            API
         ****************************************************************** */

        public void Clear()
        {
            Contact = new Contact();
            StateHasChanged();
        }

        public void setCompanyId(int companyId)
        {
            CompanyId = companyId;
        } 

        /* *******************************************************************
            Data Methods
         ****************************************************************** */

        public Contact GetContact(int contactId)
        {
            Contact contact = Repository.GetContact(contactId);
            if (contact != null && contact.Phones == null)
            {
                contact.Phones = Repository.GetPhonesForContact(contactId);
            }
            return contact;
        }



        /* *******************************************************************
            Handlers
         ****************************************************************** */

        //protected void HandleContactTypeClick()
        //{
        //    contactTypeList.Show();
        //    JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-1|company-type");
        //}

        protected void HandlePhoneTypeClick()
        {
            phoneTypeList.Show();
            if (Globals.CurrentPhoneIndex >= 0)
            {
                string index = Globals.CurrentPhoneIndex.ToString();
                JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-1|phone-type-{index}");
            }
            else
            {
                JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-1|phone-type-new");
            }
        }


        public void HandleSetPhoneType(string value)
        {
            if (Globals.CurrentPhoneIndex < 0)
            {
                NewPhone.Type = value;
            }
            else
            {
                Contact.Phones[Globals.CurrentPhoneIndex].Type = value;
            }
            
            Globals.CurrentPhoneIndex = -1;
            JsRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec-2");
        }



        /* *******************************************************************
            Form-Related Methods
         ****************************************************************** */
        protected void HandleValidSubmit()
        {
            if (String.IsNullOrEmpty(Contact?.FirstName) && String.IsNullOrEmpty(Contact?.LastName)) return;
            StatusMessage = "Saved";
            if (Contact.ContactId < 1)
            {
                _context.Contacts.Add(Contact);
                if (!String.IsNullOrWhiteSpace(NewPhone.Number) && !String.IsNullOrWhiteSpace(NewPhone.Type))
                {
                    if (Contact.Phones == null) Contact.Phones = new List<Phone>(); 
                    Contact.Phones.Add(NewPhone);
                }
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(NewPhone.Number) && !String.IsNullOrWhiteSpace(NewPhone.Type))
                {
                    NewPhone.ContactId = Contact.ContactId;

                    if (Contact.Phones == null)
                    {
                        Contact.Phones = new List<Phone>();
                    }
                    Contact.Phones.Add(NewPhone);
                }
            }
            _context.SaveChanges();
            if (!IsPartial)
            {
            }
            else if (Contact.ContactId > 0)
            {
                var ccr = new CompanyContactRelationship () 
                { 
                    CompanyId = CompanyId,
                    ContactId = Contact.ContactId,
                    Name = "Contact"
                };
                _context.CompanyContactRelationships.Add(ccr);
                _context.SaveChanges();
                NavManager.NavigateTo("/companies", true);
            }
            Redirect();
        }

        protected void HandleInvalidSubmit()
        {
            StatusMessage = "There was an error submitting the form";
        }

        protected void HandleCancel()
        {
            Redirect();
            //if (IsPartial)
            //{
            //}
            //else
            //{
            //    JsRuntime.InvokeVoidAsync(identifier: "hideElementsWithClass", "bs-dialog");
            //}
        }

        protected void Redirect()
        {
            switch (FromPage)
            {
                case "companies":
                    NavManager.NavigateTo("/companies", true);
                    break;
                case "contacts":
                    NavManager.NavigateTo("/contacts", true);
                    break;
            }
        }


    }
}
