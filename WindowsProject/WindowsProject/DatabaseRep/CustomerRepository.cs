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
    class CustomerRepository : Repository<Consumer>, ICustomerRepository
    {


        //public Task<User> GetByName(string name)
        //{
        //    return context.Set<Author>().FirstOrDefaultAsync(author => author.Name == name);
        //} 
        public CustomerRepository(ShopManagementContext dbContext)
        : base(dbContext)
        {

        }
    }

    }
