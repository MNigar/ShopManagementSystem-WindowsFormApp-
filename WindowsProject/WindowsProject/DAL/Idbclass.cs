using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject.DAL
{
    public class Idbclass : Idb
    {


        public Idbclass()
        {
        }

        public void Delete(int item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(User item)
        {
            using (ShopManagementContext context = new ShopManagementContext()) {

                context.Users.Add(item);
                context.SaveChanges();

            }
          
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(User item)
        {
            throw new NotImplementedException();
        }
    }
}
