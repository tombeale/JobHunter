using JobHunter.Models;
using BlueSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Application
{
    public static class Globals
    {
        public static int CurrentPhoneIndex { get; set; }

        public static string TechExportPath { get; set; } = @"F:\Projects\Resume2020\wwwroot\scripts";
        public static User CurrentUser { get; set; }

        public static List<DDOption> GetActionStatuses()
        {
            List<DDOption> list = new List<DDOption>();
            list.Add(new DDOption("todo",      "To Do"));
            list.Add(new DDOption("prep",      "Preparing"));
            list.Add(new DDOption("sched",     "Scheduled"));
            list.Add(new DDOption("started",   "In Progress"));
            list.Add(new DDOption("waiting",   "Waiting"));
            list.Add(new DDOption("movedon",   "Moved On"));
            list.Add(new DDOption("nogo",      "No-Go"));
            list.Add(new DDOption("hold",      "On Hold"));
            list.Add(new DDOption("cancelled", "Cancelled"));
            list.Add(new DDOption("expired",   "Expired"));
            list.Add(new DDOption("done",      "Complete"));

            return list;
        }

    }
}
