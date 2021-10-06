using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll(string fileName);
        IEnumerable<T> FindAll(string fileName, Func<T,bool> predicate);
        T Find(Func<T,bool> predicate);
        T Update(T obj);
        IEnumerable<T> Update(string fileName, Func<T, bool> predicate, T obj);
        void Delete();
        bool Save(string fileName, IEnumerable<T> objects);

    }
}
