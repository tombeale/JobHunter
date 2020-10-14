using BlueSite.Data.Entities;
using JobHunter.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JobHunter.Application
{
    public static class Utilities
    {
        [Inject] static IJSRuntime JsRuntime { get; set; }
        public static string Truncate(string original, int limit)
        {
            return (original.Length <= limit) ? original : original.Substring(0,limit-3) + "...";
        }

        public static bool GetDoneFromStatus(ActionItem action)
        {
            if (action.IsDone) return true;
            switch (action.Status)
            {
                case "expired":
                case "cancelled":
                case "done":
                    return true;
            }
            return false;
        }

        public static string GetFriendlyDDName(string key, List<DDOption> items)
        {
            var fs = items.Where(s => s.Key == key).Select(s => s.Value).FirstOrDefault();
            if (fs == null) fs = "";
            return fs;
        }

        public static string GetFriendlyStatusName(string key, List<DDOption> statuses)
        {
            var fs = statuses.Where(s => s.Key == key).Select(s => s.Value).FirstOrDefault();
            if (fs == null) fs = "";
            return fs;
        }

        public static string GetFriendlyTypeName(string key, List<DDOption> types)
        {
            var fs = types.Where(s => s.Key == key).Select(s => s.Value).FirstOrDefault();
            if (fs == null) fs = "";
            return fs;
        }

        public static string GetColorStyleFromStatus(string status)
        {
            string color = "#8ad88a";
            switch (status)
            {
                case "expired":
                case "cancelled":
                case "done":
                    color = "#eee";
                    break;
                default:
                    color = "#8ad88a";
                    break;
            }
            return color;
        }

        public static string FormatPhoneNumber(string number)
        {
            string formattedNumber = number;
            number = Regex.Replace(number, @"[^0-9]", "");
            switch (number.Length)
            {
                case 11:
                    formattedNumber = String.Format("{0:# (###) ###-####}", Convert.ToInt64(number));
                    break;
                case 10:
                    formattedNumber = String.Format("{0:(###) ###-####}", Convert.ToInt64(number));
                    break;
                case 7:
                    formattedNumber = String.Format("{0:###-####}", Convert.ToInt64(number));
                    break;
            }
            return formattedNumber;
        }

        public static Address GetAddress<T>(T Obj)
        {
            Address address  = new Address();
            address.Address1 = typeof(T).GetProperty("Address1")?.GetValue(Obj)?.ToString();
            address.Address2 = typeof(T).GetProperty("Address2")?.GetValue(Obj)?.ToString();
            address.City     = typeof(T).GetProperty("City")?.GetValue(Obj)?.ToString();
            address.State    = typeof(T).GetProperty("State")?.GetValue(Obj)?.ToString();
            address.Zip      = typeof(T).GetProperty("Zip")?.GetValue(Obj)?.ToString();
            return address;
        }

        public static string GetActionLink(ActionItem action, int? companyId, string fromPage = "")
        {
            string url = $"/actionedit/{action.ActionItemId}";
            switch (action.Type?.ToLower())
            {
                case "meeting":
                    if (action.Status == "prep")
                    {
                        url = $"/meetingprep/{action.ActionItemId}";
                    }
                    else
                    {
                        url = $"/meetingview/{action.ActionItemId}";
                    }
                    break;
            }
            url = $"{url}?CompanyId={companyId}&FromPage={fromPage}";
            return url;
        }

        public static string GetDirections(Address address)
        {
            User user = Globals.CurrentUser;
            Address userAddress = GetAddress<User>(user);
            string addr1 = userAddress.GetAddressString().Replace(" ", "+");
            string addr2 = address.GetAddressString().Replace(" ", "+");
            string url   = $"https://www.google.com/maps/dir/{addr1}/{addr2}";
            return url;
        }

        public static Dictionary<string, string> ParseQueryString(string uri) 
        {
            var dict = new Dictionary<string, string>();
            if (!String.IsNullOrEmpty(uri))
            {
                if (uri.Contains('?')) uri = uri.Split('?')[1];
            }
            if (!String.IsNullOrEmpty(uri))
            {
                string[] items = uri.Split('&');
                for (int a=0;a<items.Length;a++)
                {
                    var vals = items[a].Split('=');
                    if (vals.Length > 0)
                    dict[vals[0]] = vals[1];
                }
            }
            return dict;
        }

        public static int ColSize(int cols)
        {
            int tw = Globals.ListTableWidth;
            return (int)((tw / 12) * cols);
        }

        /* *********************************************
         * Lookup Tables
         * ******************************************* */

        public static List<DDOption> GetPhoneTypeLookup(List<PhoneType> phoneTypes)
        {
            List<DDOption> list = new List<DDOption>();
            foreach (var pt in phoneTypes)
            {
                if (pt != null) list.Add(new DDOption(pt.Type, pt.Name));
            }
            return list;
        }

    }
}
