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



        [Parameter]
        public string contactId { get; set; } = null;

        protected Contact Contact;

        public Phone NewPhone = new Phone();
        protected SelectListing phoneTypeList;
        protected List<DDOption> PhoneTypes;

        JobHuntRepository Repository;

        protected string StatusMessage = "";

        /* *******************************************************************
            Startup Events
        ******************************************************************* */

        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);

            PhoneTypes = new List<DDOption>();
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
            if (G.CurrentPhoneIndex >= 0)
            {
                string index = G.CurrentPhoneIndex.ToString();
                JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-1|phone-type-{index}");
            }
            else
            {
                JsRuntime.InvokeVoidAsync(identifier: "locateElementBelowParent", $"select-list-sec-1|phone-type-new");
            }
        }


        public void HandleSetPhoneType(string value)
        {
            if (G.CurrentPhoneIndex < 0)
            {
                NewPhone.Type = value;
            }
            else
            {
                Contact.Phones[G.CurrentPhoneIndex].Type = value;
            }
            
            G.CurrentPhoneIndex = -1;
            JsRuntime.InvokeVoidAsync(identifier: "hideElement", "select-list-sec-2");
        }



        /* *******************************************************************
            Form-Related Methods
         ****************************************************************** */
        protected void HandleValidSubmit()
        {
            StatusMessage = "Saved";
            if (Contact.ContactId < 1)
            {
                _context.Contacts.Add(Contact);
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(NewPhone.Number) && !String.IsNullOrWhiteSpace(NewPhone.Type))
                {
                    NewPhone.ContactId = Contact.ContactId;
                    NewPhone.Number    = Regex.Replace(NewPhone.Number, @"[^0-9]", "");

                    if (Contact.Phones == null)
                    {
                        Contact.Phones = new List<Phone>();
                    }
                    Contact.Phones.Add(NewPhone);
                }
            }
            StateHasChanged();
            _context.SaveChanges();
            NewPhone = new Phone();
        }

        protected void HandleInvalidSubmit()
        {
            StatusMessage = "There was an error submitting the form";
        }


    }
}
