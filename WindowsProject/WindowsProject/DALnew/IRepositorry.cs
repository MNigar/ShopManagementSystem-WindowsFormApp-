using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.Models;

namespace WindowsProject.DALnew
{
  public  interface IRepositorry<T> where T : class
    {   
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T item);
        void Update(T item);
        void Delete(int item);
        void Save();



    }
}
