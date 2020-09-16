using System;
using System.Collections.Generic;
using System.Linq;
using JobHunter.Application;

namespace JobHunter.Models
{
    public class LookUps
    {
        public List<DDOption> ActionTypes { get; set; }
        public List<DDOption> Statuses    { get; set; }

        public string GetFriendlyName(string list, string key)
        {
            List<DDOption> items = new List<DDOption>();
            switch(list.ToLower())
            {
                case "actiontype":
                    items = ActionTypes;
                    break;
                case "status":
                    items = Statuses;
                    break;
                default:
                    return key;
            }
            var fn = items.Where(s => s.Key == key).Select(s => s.Value).FirstOrDefault();
            if (fn == null) fn = key;
            return fn;
        }
    }
}
