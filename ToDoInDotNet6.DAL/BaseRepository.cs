using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.DAL.Abstract;
using ToDoInDotNet6.Models.Data;

namespace ToDoInDotNet6.DAL
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DataContext _context;
        public BaseRepository(DataContext context)
        {
            _context = context;
        }

      
        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
           return _context.Set<T>();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
