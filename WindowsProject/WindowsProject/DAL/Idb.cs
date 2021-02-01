using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.Models;

namespace WindowsProject.DAL
{
    public  interface Idb
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Insert(User item);
        void Update(User item);
        void Delete(int item);
        void Save();




    }
}
