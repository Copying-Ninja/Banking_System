using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    interface IObject
    {
        
        Guid ID { get; set; }
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
        //void Update(object obj);
    }
}
