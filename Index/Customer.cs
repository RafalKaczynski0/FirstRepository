using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    public class Customer
    {
        public string Name { get; set; }
        public string LicenseNumber { get; set; }

        public Customer(string name, string licenseNumber)
        {
            Name = name;
            LicenseNumber = licenseNumber;
        }
    }

}
