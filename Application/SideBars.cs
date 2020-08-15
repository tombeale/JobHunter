using BlueSite.Data.Entities;
using System.Collections.Generic;

namespace JobHunter.Application
{
    public static class SideBars
    {

        public static List<MenuItem> GetMenuSet(string menuType)
        {
            switch (menuType.ToLower())
            {
                case "companies":
                    return GetCompanyListSet();
                case "todolist":
                    return GetToDoListSet();
                case "prepmeeting":
                    return GetPrepMeetingSet();
                case "editmeeting":
                    return GetEditMeetingSet();
                case "viewmeeting":
                    return GetViewMeetingSet();
                case "tech":
                    return GetTechSet();
                default:
                    return new List<MenuItem>();
            }
        }
        public static List<MenuItem> GetToDoListSet()
        { 
            List<MenuItem> list = new List<MenuItem>();
            list.Add(new MenuItem("", "", "Show/Hide Done", "toggledone", "option"));
            list.Add(new MenuItem("", "", "Remove Done",    "deletedone", "option"));
            return list;
        }
        public static List<MenuItem> GetCompanyListSet()
        { 
            List<MenuItem> list = new List<MenuItem>();
            list.Add(new MenuItem("", "", "All Contacts", "togglecontacts", "option"));
            return list;
        }
        public static List<MenuItem> GetViewMeetingSet()
        { 
            List<MenuItem> list = new List<MenuItem>();
            list.Add(new MenuItem("", "", "Prepare",     "prepmeeting", "option"));
            list.Add(new MenuItem("", "", "Edit Action", "editaction",  "option"));
            return list;
        }
        public static List<MenuItem> GetPrepMeetingSet()
        { 
            List<MenuItem> list = new List<MenuItem>();
            list.Add(new MenuItem("", "", "View Meeting", "viewmeeting", "option"));
            list.Add(new MenuItem("", "", "Edit Action",  "editaction",  "option"));
            return list;
        }
        public static List<MenuItem> GetEditMeetingSet()
        { 
            List<MenuItem> list = new List<MenuItem>();
            list.Add(new MenuItem("", "", "Prepare",      "prepmeeting", "option"));
            list.Add(new MenuItem("", "", "View Meeting", "viewmeeting", "option"));
            return list;
        }
        public static List<MenuItem> GetTechSet()
        { 
            List<MenuItem> list = new List<MenuItem>();
            list.Add(new MenuItem("", "", "Sort Name",     "sortname",     "option"));
            list.Add(new MenuItem("", "", "Sort Name Dsc", "sortnamedesc", "option"));
            list.Add(new MenuItem("", "", "Sort Year",     "sortyear",     "option"));
            list.Add(new MenuItem("", "", "Sort Year Dsc", "sortyeardesc", "option"));
            list.Add(new MenuItem("", "", "Export",        "export",       "option"));
            list.Add(new MenuItem("", "", "Settings",      "export",       "option"));
            return list;
        }
    }
}
