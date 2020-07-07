using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Models
{
    public class ImgButton
    {
        public string ImageRoot { get; set; }
        public string Action { get; set; }
        public string ToolTip { get; set; } = "";
        public string Ext { get; set; } = "png";

        public ImgButton( string imageRoot, string action, string tooltip, string ext = "png")
        {
            ImageRoot = imageRoot;
            Action = action;
            ToolTip = tooltip;
        }

        public string GetImage(string root, int version)
        {
            return $"{ImageRoot}-{version}.{Ext}";
        }

        public string GetMouseOver()
        {
            return $"setIconImage(this, '{ImageRoot}-1.png')";
        }

        public string GetMouseOut()
        {
            return $"setIconImage(this, '{ImageRoot}-0.png')";
        }
    }
}
