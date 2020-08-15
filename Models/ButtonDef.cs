using System;
using System.Collections.Generic;
using System.Text;

namespace JobHunter.Models
{
    public class ButtonDef
    {
        public string Label {  get; set; }
        public string Tag {  get; set; }
        public string Class { get; set; }

        public ButtonDef(string raw = "")
        {
            var b = raw.Split(':');
            int l = b.Length;
            Label = (l > 0) ? b[0] : "";
            Tag   = (l > 1) ? b[1] : "";
            Class = (l > 2) ? b[2] : "";
        }

        public ButtonDef(string label, string tag, string btnClass = "")
        {
            Label = label;
            Tag = tag;
            Class = btnClass;
        }


    }
}
