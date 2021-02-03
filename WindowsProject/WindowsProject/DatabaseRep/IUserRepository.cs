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
  public  interface IUserRepository:IRepository<User>
    {
         bool IfExist(string email, string password, List<User> users);
        bool IfAlreadyExist(string email, List<User> users);


    }
}
