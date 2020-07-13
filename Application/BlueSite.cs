using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using JobHunter.Models;

namespace JobHunter.Application
{
    public static class Globals
    {
        public static List<DDOption> GetActionStatuses()
        {
            List<DDOption> list = new List<DDOption>();
            list.Add(new DDOption("todo",      "To Do"));
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
        public static List<DDOption> GetActionTypes()
        {
            List<DDOption> list = new List<DDOption>();
            list.Add(new DDOption("todo",              "To Do"));
            list.Add(new DDOption("research",          "Research"));
            list.Add(new DDOption("planning",          "Planning"));
            list.Add(new DDOption("tooldev",           "Tool Development"));
            list.Add(new DDOption("recruiter",         "Recruiter Contact"));
            list.Add(new DDOption("application",       "Application"));
            list.Add(new DDOption("phonecontact",      "Phone Contact"));
            list.Add(new DDOption("emailcontact",      "Email Contact"));
            list.Add(new DDOption("phoneinterview",    "Phone Interview"));
            list.Add(new DDOption("inpersoninterview", "In Person Interview"));

            return list;
        }
    }
}
