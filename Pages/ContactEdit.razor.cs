using BlueSite.Data;
using BlueSite.Data.Entities;
using JobHunter.Application;
using JobHunter.Models;
using JobHunter.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class ContactEditBase : ComponentBase
    {
        [Inject] IJSRuntime JSRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }



        [Parameter]
        public string contactId { get; set; } = null;

        protected Contact Contact;
        private int ContactId;

        JobHuntRepository Repository;

        protected string StatusMessage = "";

        /* *******************************************************************
            Startup Events
        ******************************************************************* */

        protected override void OnInitialized()
        {
            Repository = new JobHuntRepository(_context);


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
            return Repository.GetContact(contactId);
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
            StateHasChanged();
            _context.SaveChanges();
        }

        protected void HandleInvalidSubmit()
        {
            StatusMessage = "There was an error submitting the form";
            if (Contact.ContactId < 1)
            {
                _context.Contacts.Add(Contact);
            }
            StateHasChanged();
            _context.SaveChanges();
        }


    }
}
