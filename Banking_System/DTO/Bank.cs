using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Bank : IObject
    {
        public static DataService<Bank> DataService { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<Guid,StaffUser> Users { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public Guid ID { get; set; } = Guid.NewGuid();
        public DateTime Created { get ;  set ; }
        public DateTime Updated { get ; set ; }
        public IEnumerable<Office> Offices { get; set; }

        public void Update()
        {
            DataService.Update(this);
        }

        public void UpdateLocalDataBank(string name, string desc)
        {
            Title = name;
            Description = desc;
            Update();
        }
        
    }
}
