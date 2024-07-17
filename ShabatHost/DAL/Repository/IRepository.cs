using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatHost.DAL.Repository
{
    public interface IRepository<T>
    {
        List<T> FindAll();
        T FindById(int id);
        bool Insert(T entity);
    }
}
