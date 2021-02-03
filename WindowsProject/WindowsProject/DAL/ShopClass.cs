using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DALnew;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject.DAL
{
    public class ShopClass : Repository<User>, IShopManagementrepository
    {


        //public Task<User> GetByName(string name)
        //{
        //    return context.Set<Author>().FirstOrDefaultAsync(author => author.Name == name);
        //} 
        public ShopClass(ShopManagementContext dbContext)
        : base(dbContext)
        {

        }

        
    }
}
