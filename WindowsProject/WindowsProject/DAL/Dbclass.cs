using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.Models;

namespace WindowsProject.DAL
{
    public class Dbclass
    {

        private readonly IShopManagementrepository _repository;
        
        public Dbclass(IShopManagementrepository repository)
        {
            _repository = repository;

        }
        public Dbclass( )
        {
            

        }
        public  void Insert(User user)
        {
            _repository.Insert(user);
        }

    }
}
