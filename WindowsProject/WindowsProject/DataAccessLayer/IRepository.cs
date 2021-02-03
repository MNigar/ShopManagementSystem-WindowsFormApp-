using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.Models;

namespace WindowsProject.DataAccessLayer
{
  public  interface IRepository<T> where T : class
    {   
        List<T> GetAll();
        T GetById(int id);
        void Insert(T item);
        void Update(T item);
        void Delete(int item);
   


    }
}
