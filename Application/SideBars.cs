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
                case "todolist":
                    return GetToDoListSet();
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
    }
}
