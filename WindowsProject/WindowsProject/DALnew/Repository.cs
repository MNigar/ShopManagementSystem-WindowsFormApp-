using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject.DALnew
{
    public class Repository<T> : IRepositorry<T> where T : class, IEntity
    {
        protected readonly ShopManagementContext context;
        private DbSet<T> entities;
        public Repository(ShopManagementContext context)
        {
            this.context = context;
            this.context.Set<T>();
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
            //if (item == null) throw new ArgumentNullException("entity");
            //entities.Add(item);
            //context.SaveChanges();
            context.Set<T>().Add(item);
            context.SaveChangesAsync();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
