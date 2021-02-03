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
    class CategoryRepository :Repository<Category>, ICategoryRepository
    {


        //public Task<User> GetByName(string name)
        //{
        //    return context.Set<Author>().FirstOrDefaultAsync(author => author.Name == name);
        //} 
        public CategoryRepository(ShopManagementContext dbContext)
        : base(dbContext)
    {

    }

}
}
