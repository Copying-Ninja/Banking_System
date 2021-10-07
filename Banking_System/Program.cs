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
        static void Main(string[] args)
        {
            int n = 3;
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
            Console.WriteLine(num);
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

    }
}
