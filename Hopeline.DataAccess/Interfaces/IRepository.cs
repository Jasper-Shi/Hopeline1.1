using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T insert(T o);
        T update(T o);
        bool delete(T o);
        string save();
        
    }
}
