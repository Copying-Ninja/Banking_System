using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public static class Banking
    {
        public static IEnumerable<Office> Offices { get; set; }
        public static IEnumerable<Bank> Banks { get; set; }
        public static IEnumerable<Product> Products { get; set; }
        public static IEnumerable<Client> Clients { get; set; }
        public static IEnumerable<StaffUser> StaffUsers { get; set; }
        public static IEnumerable<Account> Accounts { get; set; }
        public static IEnumerable<Address> Addresses { get; set; }
        public static IEnumerable<ContactInfo> ContactInfos { get; set; }


    }
}
