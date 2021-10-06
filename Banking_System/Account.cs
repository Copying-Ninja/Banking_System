using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Account : IObject
    {
        
        public AcountType Type { get; set; }
        public  double Balance { get; set; }
        public string Currency { get; set; }
        public Guid OwnerId { get; set; }
        public AcountStatus Status { get; set; }
        public Guid ID { get ; set; }
        public DateTime Created { get ; set ; }
        public DateTime Updated { get ; set ; }
    }
}
