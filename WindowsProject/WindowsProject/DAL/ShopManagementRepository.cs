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
    public class ShopManagementRepository : Repository<User>, IShopManagementrepository
    {
        public ShopManagementRepository(ShopManagementContext dbContext)
        : base(dbContext)
        {

        }
    }
}