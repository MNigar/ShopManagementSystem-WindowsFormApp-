using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject.DAL
{
    public class Categoryclass : ICategory
    {
        ShopManagementContext context = new ShopManagementContext();
        public void Delete(int item)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            var query = context.Categories.ToList();
            return query;
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category item)
        {
            context.Categories.Add(item);
            context.SaveChanges();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
