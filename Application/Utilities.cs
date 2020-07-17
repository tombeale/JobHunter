using BlueSite.Data.Entities;
using JobHunter.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

    }
}
