using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DataAccessLayer;
using WindowsProject.DataBaseContext;
using WindowsProject.Models;

namespace WindowsProject.DatabaseRep
{
   public class LogProductRepository: Repository<LogProduct>, ILogProductRepository
    {


        public LogProductRepository(ShopManagementContext dbContext)
        : base(dbContext)
    {

    }
}
}
