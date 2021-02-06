using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject.DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ShopManagementContext context;
   
        public Repository(ShopManagementContext context)
        {
            this.context = context;
            this.context.Set<T>();
        }

        public void Delete(int item)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            using (ShopManagementContext context = new ShopManagementContext())
            {

                return context.Set<T>().ToList();
            }

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
            context.SaveChanges();
        }

        public void Update(T item)
        {
            var entity = context.Entry(item);
            entity.State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
