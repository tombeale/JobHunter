using BlueSite.Data;
using BlueSite.Data.Entities;
using Microsoft.AspNetCore.Components;
using System;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Pages
{
    public class CompanyEditBase : ComponentBase
    {
        [Inject] IJSRuntime JsRuntime { get; set; }
        [Inject] BlueSiteContext _context { get; set; }


        [Parameter]
        public string Id { get; set; } = null;

        public Company company;
        JobHuntRepository Repository;

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
            if (Id != null)
            {
                int CompanyId = Convert.ToInt32(Id);
                company = GetCompany(CompanyId);
            }
            else
            {
                company = new Company();
            }
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (Id != null)
            {
                await SetTitle($"Viewing Company Id #{company.CompanyId}");
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

        protected void HandleValidSubmit()
        {
            Console.WriteLine("OnValidSubmit");
        }

        /* *******************************************************************
            Form-Related Methods
         ****************************************************************** */
        public void validateForm()
        {
            if (company != null)
            {

            }
        }

    }
}
