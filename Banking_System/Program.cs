using Banking_System.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Program
    {
        public static void Do(ref int num)
        {
            num = 10;
        }
        public static void Do(out Bank bank )
        {
           
            bank = new Bank();
        }
        public static void Do(params string[] args)
        {
            
        }
        

        

        public static Data MyВ(Data data1, Data data2)
        {
            return new Data() { MyProperty1 = data1.MyProperty1 + data2.MyProperty1 };
        }
        static void Main(string[] args)
        {

            var officeIds = ReportService.GetOfficeIdBy(0, 300);
            foreach (var item in officeIds)
            {
                Console.WriteLine(item);
            }

            var acc = DataGenerate.CreateAccountList(2);
            var avg = acc.Avg();
            Console.WriteLine(avg);

            var strigs = new List<string>() { "q1233", "adgauidk", "skgff" };
            var str = strigs.Select();
            Console.WriteLine(str);


            var off = DataGenerate.CreateOffice();
            //Console.WriteLine(off.StaffCount);
            /*int n = 3;
            //var bank = new Bank();
            //bank.Title = "MonoBank";
            string[] arr = { "s1", "s2" };
            Do(out Bank bank);
            Do(ref n);
            Do(arr);
            var v = Int32.TryParse("s123", out int num);
            dynamic obj = 5;
            var va = obj;
            Console.WriteLine(bank);
            Console.WriteLine(n);
            Console.WriteLine(v);
            Console.WriteLine(num);*/
            /*var sevice = new DataService<Bank>();
            var banks = new List<Bank>();
            for (int i = 0; i < 10; i++)
            {
                banks.Add(new Bank
                {
                    Title = $"Bank #{i}",
                    Description = $"Desc of Bank #{i}",
                    Created = DateTime.Now,
                    Updated = DateTime.Now
                });
            }


            var issaved = sevice.Save(nameof(Bank), banks);
          */

            Console.ReadKey();
        }
    }
    class Data
    {
        public int MyProperty0 { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2{ get; set; }
        public int MyProperty3 { get; set; }

        public static Data operator +(Data a, Data b)
        {
            return new Data() { MyProperty1 = a.MyProperty1 + b.MyProperty1 };
        }
    }
}
