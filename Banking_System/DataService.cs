    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Banking_System
    {
        public class DataService<T> : IRepository<T> where T : class
        {

            public bool Save(string fileName, IEnumerable<T> objects)
            {
                var data = JsonConvert.SerializeObject(objects);
                return IOService.Write(fileName, data);
            }
            public IEnumerable<T> Update(string fileName, Func<T, bool> predicate, T obj)
            {
                throw new NotImplementedException();
            }

            void IRepository<T>.Delete()
            {
                throw new NotImplementedException();
            }

            T IRepository<T>.Find(Func<T, bool> predicate)
            {
                throw new NotImplementedException();
            }

            IEnumerable<T> IRepository<T>.FindAll(string fileName, Func<T, bool> predicate)
            {
                var colection = JsonConvert.DeserializeObject<IEnumerable<T>>(IOService.Read(fileName));
                return colection.Where(predicate);
            }

            IEnumerable<T> IRepository<T>.GetAll(string fileName)
            {
                return JsonConvert.DeserializeObject<IEnumerable<T>>(IOService.Read(fileName));
            }

            T IRepository<T>.Update(T obj)
            {
                throw new NotImplementedException();
            }
        }
    }
