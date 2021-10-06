using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public static class DataGenerate
    {
        static Random _rnd = new Random();
        public static Address CreateAddress()
        {
            Address address = new Address()
            {
                Country = $"Country {_rnd.Next(100)}",
                City = $"City {_rnd.Next(1000)}",
                Street = $"Street {_rnd.Next(500)}",
                HouseNumber = _rnd.Next(500).ToString()
            };
            return address;
        }
        public static Office CreateOfice()
        {
            
            Office office = new Office()
            {
                Address = CreateAddress(),
                Title = $"Office {_rnd.Next(15000)}",
                Description = $"Description {_rnd.Next(15000)}",
                StartTime = Get_rndDate(),
                EndTime = Get_rndDate(),
                StaffCount = _rnd.Next(500),
                OfficeType = Get_rndEnumValue<ClientOfficeType>(),
                Created = Get_rndDate(),
                Updated = Get_rndDate(),
                ID = Guid.NewGuid()
            };
            return office;
        }
        public static Account CreateAccount()
        {

            Account acc = new Account()
            {
                Type = Get_rndEnumValue<AcountType>(),
                Balance =  _rnd.Next(9999999),
                Currency = $"Currency {_rnd.Next(100)}",
                OwnerId = Guid.NewGuid(),
                Status = Get_rndEnumValue<AcountStatus>(),
                Created = Get_rndDate(),
                Updated = Get_rndDate(),
                ID = Guid.NewGuid()
            };
            return acc;
        }
        public static ContactInfo CreateContactInfo()
        {
            var conInfo = new ContactInfo()
            {
                Telephone = $"+{_rnd.Next(10000000,999999999)}",
                Email = $"{_rnd.Next(100, 99999999)}@gmail.com",
                Website = $"www.{_rnd.Next(99,99999999)}.com"
            };
            return conInfo;
        }
        public static Client CreateClient()
        {
            var client = new Client()
            {
                Type = Get_rndEnumValue<ClientOfficeType>(),
                Name = $"Name_{_rnd.Next(5000)}",
                Description = $"Description {_rnd.Next(15000)}",
                Accounts = CreateAccountList(_rnd.Next(10)),
                Buckets = CreateGuidList(_rnd.Next(100)),
                Created = Get_rndDate(),
                Updated = Get_rndDate(),
                ID = Guid.NewGuid()
            };
            return client;
        }
        public static IEnumerable<Client> CreatClientList(int quantity)
        {
            var objects = new List<Client>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateClient());
            }
            return objects;
        }
        public static IEnumerable<ContactInfo> CreatContactInfoList(int quantity)
        {
            var objects = new List<ContactInfo>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateContactInfo());
            }
            return objects;
        }
        public static IEnumerable<Guid> CreateGuidList(int quantity)
        {
            var objects = new List<Guid>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(Guid.NewGuid());
            }
            return objects;
        }
        public static IEnumerable<Account> CreateAccountList(int quantity)
        {
            var objects = new List<Account>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateAccount());
            }
            return objects;
        }


/*        public static IEnumerable<T> CreateObjectList(int quantity) where T : class
        {
            var objects = new List<T>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateAddress());
            }
            return objects;
        }*/
        public static DateTime Get_rndDate()
        {
            DateTime start = new DateTime(1955, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_rnd.Next(range));
        }
        public static T Get_rndEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(_rnd.Next(v.Length));
        }

    }
}
