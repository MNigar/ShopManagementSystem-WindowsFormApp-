using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject.DALnew
{
    public class Repository<T> : IRepositorry<T> where T : class, new()
    {
        private readonly ShopManagementContext _dbContext;

        public Repository(ShopManagementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
             _dbContext.Set<T>().Add(item);
             _dbContext.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
