using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Models
{

    public class StateList
    {
        List<SectionState> Listing = new List<SectionState>();

        public StateList(string raw = "")
        {
            if (!String.IsNullOrEmpty(raw))
            {
                Listing = Parse(raw);
            }
        }

        private List<SectionState> Parse(string raw)
        {
            List<SectionState> list = new List<SectionState>();
            string[] states = raw.Split('|');
            for (int a=0;a<states.Length;a++)
            {
                list.Add(new SectionState(states[a]));
            }
            return list;
        }

        public SectionState GetState(int id)
        {
            var ss = Listing.Where(s => s.Id == id).FirstOrDefault();
            if (ss == null)
            {
                ss = new SectionState(id);
                Listing.Add(ss);
            }
            return ss;
        }

        public void Toggle(int id, string key)
        {
            Listing.Where(s => s.Id == id).FirstOrDefault().Toggle(key);
        }

        public void Clear()
        {
            foreach (var s in Listing)
            {
                s.Clear();
            }
        }

        public override string ToString()
        {
            List<string> buffer = new List<string>();
            foreach (var state in Listing)
            {
                buffer.Add(state.ToString());
            }
            return String.Join("|", buffer.ToArray());
        }

    }

    public class SectionState
    {
        public int Id { get; set; }
        public bool Actions { get; set; }
        public bool Contacts { get; set; }
        public bool Notes { get; set; }
    
        
        public SectionState(int id, bool actions, bool contacts, bool notes)
        {
            Id       = id;
            Actions  = actions;
            Contacts = contacts;
            Notes    = notes;
        }

        public SectionState(int id)
        {
            Id       = id;
            Actions  = false;
            Contacts = false;
            Notes    = false;
        }

        public string GetStyle(string key)
        {
            string style = "";
            switch (key.ToLower())
            {
                case "actions":
                    style = (!Actions) ? "display: none;" : "";
                    break;
                case "contacts":
                    style = (!Contacts) ? "display: none;" : "";
                    break;
                case "notes":
                    style = (!Notes) ? "display: none;" : "";
                    break;
            } 
            return style;
        }

        public void Clear()
        {
            Actions  = false;
            Contacts = false;
            Notes    = false;
        }

        public SectionState(string raw)
        {
            string[] ss = raw.Split(':');
            Id       = Convert.ToInt32(ss[0]);
            Actions  = (ss[1] == "1");
            Contacts = (ss[2] == "1");
            Notes    = (ss[3] == "1");
        }

        public void Toggle(string key)
        {
            switch (key.ToLower())
            {
                case "actions":
                    Actions = !Actions;
                    break;
                case "contacts":
                    Contacts = !Contacts;
                    break;
                case "notes":
                    Notes = !Notes;
                    break;
            }
        }

        public override string ToString()
        {
            List<string> buffer = new List<string>();
            buffer.Add(Id.ToString());
            buffer.Add(Actions  ? "1" : "");
            buffer.Add(Contacts ? "1" : "");
            buffer.Add(Notes    ? "1" : "");
            return String.Join(":", buffer.ToArray());
        }

        
    }


}
