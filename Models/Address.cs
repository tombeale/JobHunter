using BlueSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobHunter.Models
{
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string GetAddressString(bool encodeSpaces = false)
        {
            List<string> buffer = new List<string>();
            if (String.IsNullOrEmpty(Address2)) {
                buffer.Add($"{Address1},");
            }
            else
            {
                buffer.Add(fix($"{Address1} {Address2},"));
            }
            buffer.Add(fix($"{City},"));
            buffer.Add(fix(State));
            buffer.Add(fix(Zip));
            string returnValue = String.Join(" ", buffer.ToArray());
            if (encodeSpaces)
            {
                returnValue = returnValue.Replace(" ", "+");
            }

            return returnValue;
        }

        private string fix(string addressPart)
        {
            if (String.IsNullOrEmpty(addressPart)) return "";
            return addressPart;
        }

    }
}
