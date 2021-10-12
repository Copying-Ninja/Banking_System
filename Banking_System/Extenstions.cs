using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public static class Extenstions
    {
        public static string Select(this IEnumerable<string> str)
        {
            return String.Join(" ; ", str) + ".";
        }

        public static double Avg(this IEnumerable<Account> accounts)
        {
            double sum = 0;
            int count = 0;
            foreach (var item in accounts)
            {
                sum += item.Balance;
                count++;
            }
            return sum / count;
        }
    }
}
