using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Product : IObject
    {
       
        public ProductType Type { get; set; }
        public string Title { get; set; }
        public string Drscription { get; set; }
        public Client Owner { get; set; }
        public double Price { get; set; }
        public TimePeriod Period { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid ID { get; set; }

    }
}
