using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Program
    {

        static void Main(string[] args)
        {
            var sevice = new DataService<Bank>();
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
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(DataGenerate.GetRandomEnumValue<AcountType>());
            }
            Console.WriteLine(DataGenerate.GetRandomDate());
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
