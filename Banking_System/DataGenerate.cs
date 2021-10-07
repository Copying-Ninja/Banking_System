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

        #region CreateObject
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
        public static Office CreateOffice()
        {
            
            Office office = new Office()
            {
                Address = CreateAddress(),
                Title = $"Office {_rnd.Next(15000)}",
                Description = $"Description {_rnd.Next(15000)}",
                StartTime = GetRandomDate(),
                EndTime = GetRandomDate(),
                StaffCount = _rnd.Next(500),
                OfficeType = GetRandomEnumValue<ClientOfficeType>(),
                Created = GetRandomDate(),
                Updated = GetRandomDate(),
            };
            return office;
        }
        public static Account CreateAccount()
        {

            Account acc = new Account()
            {
                Type = GetRandomEnumValue<AcountType>(),
                Balance =  _rnd.Next(9999999),
                Currency = $"Currency {_rnd.Next(100)}",
                OwnerId = Guid.NewGuid(),
                Status = GetRandomEnumValue<AcountStatus>(),
                Created = GetRandomDate(),
                Updated = GetRandomDate(),
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
                Type = GetRandomEnumValue<ClientOfficeType>(),
                Name = $"Name_{_rnd.Next(5000)}",
                Description = $"Description {_rnd.Next(15000)}",
                Accounts = CreateAccountList(_rnd.Next(10)),
                Buckets = CreateGuidList(_rnd.Next(100)),
                Created = GetRandomDate(),
                Updated = GetRandomDate(),
            };
            return client;
        }
        public static StaffUser CreateStaffUser()
        {
            var staff = new StaffUser()
            {
                Type = GetRandomEnumValue<ClientOfficeType>(),
                Name = $"Name_{_rnd.Next(5000)}",
                Description = $"Description {_rnd.Next(15000)}",
                Accounts = CreateAccountList(_rnd.Next(10)),
                Buckets = CreateGuidList(_rnd.Next(100)),
                Created = GetRandomDate(),
                Updated = GetRandomDate(),
                JobTitle = $"Position {_rnd.Next(20)}",
            };
            return staff;
        }
        public  static TimePeriod CreateTimePeriod()
        {
            var period = new TimePeriod()
            {
                StartDate = GetRandomDate(),
                EndDate = GetRandomDate(),
            };
            return period;
        }
        public static Product CreateProduct()
        {
            var staff = new Product()
            {
                Type = GetRandomEnumValue<ProductType>(),
                Title = $"Product #{_rnd.Next(9999)}",
                Owner = CreateClient(),
                Description = $"Description {_rnd.Next(99999)}",
                Price = _rnd.Next(100, 99999) + _rnd.NextDouble(),
                Period = CreateTimePeriod(),
                Created = GetRandomDate(),
                Updated = GetRandomDate(),              
            };
            return staff;
        }
        public static Bank CreateBank()
        {
            var bank = new Bank()
            {
                Title = $"Bank #{_rnd.Next(9999)}",
                Accounts = CreateAccountList(_rnd.Next(9999)),
                Description = $"Description of Bank {_rnd.Next(99999)}",
                Created = GetRandomDate(),
                Updated = GetRandomDate(),
                Offices = CreateOfficeList(_rnd.Next(99999)),
                //Users
            };
            return bank;
        }
        public static void CreateBanking()
        {
            Banking.Accounts = CreateAccountList(_rnd.Next(100000,9999999));
            Banking.Addresses = CreateAddressList(_rnd.Next(1000,999999));
            Banking.Banks = CreateBankList(_rnd.Next(100,999999));
            Banking.Clients = CreateClientList(_rnd.Next(10000,999999999));
            Banking.ContactInfos = CreateContactInfoList(_rnd.Next(10000,999999999));
            Banking.Offices = CreateOfficeList(_rnd.Next(1000,999999));
            Banking.Products = CreateProductList(_rnd.Next(1000,999999999));
            Banking.StaffUsers = CreateStaffUserList(_rnd.Next(10000, 999999999));
        }
        #endregion

        #region CreateObjectList

        public static IEnumerable<Address> CreateAddressList(int quantity)
        {
            var objects = new List<Address>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateAddress());
            }
            return objects;
        }
        public static IEnumerable<Office> CreateOfficeList(int quantity)
        {
            var objects = new List<Office>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateOffice());
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
        
        public static IEnumerable<StaffUser> CreateStaffUserList(int quantity)
        {
            var objects = new List<StaffUser>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateStaffUser());
            }
            return objects;
        }
        public static IEnumerable<Client> CreateClientList(int quantity)
        {
            var objects = new List<Client>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateClient());
            }
            return objects;
        }
        public static IEnumerable<ContactInfo> CreateContactInfoList(int quantity)
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
        public static IEnumerable<Product> CreateProductList(int quantity)
        {
            var objects = new List<Product>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateProduct());
            }
            return objects;
        }
        public static IEnumerable<Bank> CreateBankList(int quantity)
        {
            var objects = new List<Bank>();
            for (int i = 0; i < quantity; i++)
            {
                objects.Add(CreateBank());
            }
            return objects;
        }

        #endregion

        public static DateTime GetRandomDate()
        {
            DateTime start = new DateTime(1955, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_rnd.Next(range));
        }
        public static T GetRandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(_rnd.Next(v.Length));
        }

    }
}
