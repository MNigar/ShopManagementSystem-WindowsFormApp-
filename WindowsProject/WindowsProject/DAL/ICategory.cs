using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.Models;

namespace WindowsProject.DAL
{
   public  interface ICategory
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Insert(Category item);
        void Update(Category item);
        void Delete(int item);
        void Save();
    }
}
