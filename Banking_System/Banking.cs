using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Banking
    {
        public IEnumerable<Office> Offices { get; set; }
        public IEnumerable<Bank> Banks { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<StaffUser> StaffUsers { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public IEnumerable<ContactInfo> ContactInfos { get; set; }


    }
}
