using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using BlueSite.Data.Entities;

namespace JobHunter.Models
{
    public class DDOption
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public DDOption(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public DDOption(ActionType actionType)
        {
            Key = actionType.ActionTypeId;
            Value = actionType.Name;
        }
    }
}
