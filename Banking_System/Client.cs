using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Client : IObject
    {
        
        public ClientOfficeType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public IEnumerable<Guid> Buckets { get; set; }
        //public int Job { get; set; }
        public Dictionary<string,object> Properties { get; set; }
        public IEnumerable<ContactInfo> Contacts { set; get; }
        public Guid ID { get ; set ; }
        public DateTime Created { get ; set ; }
        public DateTime Updated { get ; set ; }
    }
}
