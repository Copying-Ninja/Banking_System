using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System.Services
{
    public class ReportService
    {
        public static IEnumerable<Account> GetAccountInfoBy(double balance, AcountType type)=>
            Banking.Accounts.Where(x => x.Balance > balance && x.Type == type);

        public static IEnumerable<Account> GetAccountInfoBy(AcountType type, DateTime updatingDate)
        {
            return Banking.Accounts.Where(x => x.Updated == updatingDate && x.Type != type);
        }

        public static IEnumerable<Bank> GetBankInfoBy(string title, char lastChar)
        {
            return Banking.Banks.Where(x => x.Title.Contains(title) && x.Title.EndsWith(lastChar.ToString()));
        }
        /*public static void GetBankInfoBy()
        {
            var balance = Banking.Banks.SelectMany(x => x.Accounts).Min(x => x.Balance);
            balance = Banking.Banks.FirstOrDefault(x => x.Accounts.Min(y => y.Balance) == balance);

        }*/

        public static IEnumerable<Bank> GetBankInfoBy(string desc, AcountStatus acountStatus)
        {
            return Banking.Banks.Where(x => x.Description.Contains(desc) && x.Accounts.Where(y => y.Status == acountStatus).Any());
        }

        public static IEnumerable<Bank> GetBankInfoBy(string country, string titleStartWith, string descEndWith)
        {
            return Banking.Banks.Where(x => x.Description.EndsWith(descEndWith) 
            && x.Title.StartsWith(titleStartWith) && x.Offices.Where(y => y.Address.Country == country).Any());
        }

        public static IEnumerable<Bank> GetBankInfoBy(double balLowwerThan, string curencyPart, ClientOfficeType notOfficeType, int staffQntHigherThan)
        {
            return Banking.Banks.Where(
                x => x.Accounts.Where(y => y.Balance < balLowwerThan && y.Currency.Contains(curencyPart)).Any() 
                && x.Offices.Where(y => y.OfficeType != notOfficeType && y.StaffCount > staffQntHigherThan).Any());
        }

        public static IEnumerable<Guid> GetOfficeIdBy( int minStaffQnt , int maxStaffQnt)
        {
            return Banking.Offices.Where(x => x.StaffCount >= minStaffQnt && x.StaffCount <= maxStaffQnt).Select(x => new Guid());
        }


    }
}
