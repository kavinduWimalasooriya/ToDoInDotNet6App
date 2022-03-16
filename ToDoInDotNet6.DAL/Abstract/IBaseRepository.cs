using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoInDotNet6.DAL.Abstract
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
