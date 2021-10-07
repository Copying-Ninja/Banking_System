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
        private IEnumerable<T> SourseList { get; set; } = new List<T>();
        public void SetSourse(IEnumerable<T> sourse)
        {
            SourseList = sourse;
        }
        public DataService(IEnumerable<T> sourse)
        {
            SourseList = sourse;
        }


            public bool Save(string fileName, IEnumerable<T> objects)
            {
                var data = JsonConvert.SerializeObject(objects);
                return IOService.Write(fileName, data);
            }
            public IEnumerable<T> Update(string fileName, Func<T, bool> predicate, T obj)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<T> Delete(IEnumerable<T> sourse, Guid objId)
            {
            if( sourse is IEnumerable<Bank>)
            {
                var list = new List<Bank>();
                return (IEnumerable<T>)list.Where(x => x.ID != objId);
            }
            return sourse;
            }

            public T First(IEnumerable<T> sourse,Func<T, bool> predicate)
            {
            return sourse.FirstOrDefault(predicate);
            }


            IEnumerable<T> IRepository<T>.FindAll(string fileName, Func<T, bool> predicate)
            {
                var colection = JsonConvert.DeserializeObject<IEnumerable<T>>(IOService.Read(fileName));
                return colection.Where(predicate);
            }

            public void Update(T obj)
            {
                if(obj is Bank)
                {
                    var dataList = SourseList as IEnumerable<Bank>;
                    var updetedObj = dataList.FirstOrDefault(x => x.ID == (obj as Bank).ID);
                    dataList = dataList.Where(x => x.ID != (obj as Bank).ID);
                    SourseList = (IEnumerable<T>)dataList.Append(obj as Bank); 
                }
            Bank bank = new Bank();
            
            }
        public T GetById(IEnumerable<T> sourse, Guid id)
        {
            return (T)(sourse as IEnumerable<IObject>).FirstOrDefault(x => x.ID == id);
        }
            
        }
    }
