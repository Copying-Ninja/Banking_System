using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> FindAll(string fileName, Func<T,bool> predicate);
        T First(IEnumerable<T> sourse ,Func<T,bool> predicate);
        void Update( T obj);
        IEnumerable<T> Update(string fileName, Func<T, bool> predicate, T obj);
        IEnumerable<T> Delete(IEnumerable<T> sourse, Guid objId);
        bool Save(string fileName, IEnumerable<T> objects);
    }
}
