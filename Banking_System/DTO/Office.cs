using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
     public class Office : IObject
    {
        public Address Address { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int StaffCount { get; set; }
        public ClientOfficeType OfficeType { get; set; }
        public DateTime Created { get ; set ; }
        public DateTime Updated { get ; set ; }
        public Guid ID { get ; set ; }
        
    }
}
