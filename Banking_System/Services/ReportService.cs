using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System.Services
{
    public class ReportService
    {
        public static IEnumerable<Account> GetAccountByCriteria(double balance, AcountType type)=>
            Banking.Accounts.Where(x => x.Balance > balance && x.Type == type);
        
    }
}
