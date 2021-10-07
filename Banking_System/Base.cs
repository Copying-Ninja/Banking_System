using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Base
    {
        public static DataService<object> DataService { get; set; }
        public void Update()
        {
            DataService.Update(this);
        }
    }
}
