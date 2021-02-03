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
    public class UserRepository : Repository<User>, IUserRepository
    {


        //public Task<User> GetByName(string name)
        //{
        //    return context.Set<Author>().FirstOrDefaultAsync(author => author.Name == name);
        //} 
        public UserRepository(ShopManagementContext dbContext)
        : base(dbContext)
        {

        }

       

       public bool IfExist(string email, string password, List<User> users)
        {
            bool result = false;
            if (users.Any(user => user.Email.ToLower() == email.ToLower()
            && user.Password.ToLower() == password.ToLower()))
            {
                result = true;
            }
            return result;
        }
        public bool IfAlreadyExist(string email, List<User> users)
        {
            bool result = false;
            if (users.Any(user => user.Email.ToLower() == email.ToLower()))

            {
                result = true;
            }
            return result;
        }

    }
}
