using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Models
{
    public class QueryString
    {
        public string Uri { get; set; }


        private Dictionary<string, string> Parameters;

        public QueryString(string uri)
        {
            Uri = uri;
            Parameters = ParseQueryString(Uri);
        }

        public string Get(string key, string defValue = "")
        {
            if (String.IsNullOrEmpty(key)) return defValue;
            string Value = "";
            if (Parameters.TryGetValue(key.ToLower(), out Value))
            {
                return Value;
            }
            return defValue;
        }

        Dictionary<string, string> ParseQueryString(string uri) 
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
                    if (vals.Length > 1)
                    dict[vals[0].ToLower()] = vals[1];
                }
            }
            return dict;
        }
    }
}
