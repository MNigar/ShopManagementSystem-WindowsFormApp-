using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DataAccessLayer;

namespace WindowsProject.Models
{
   public class Category
    {
        public Category()
        {
            Product = new List<Product>();
        }
        public int Id { get; set; }

        public string Name { get; set; }
        public int Status { get; set; }
        public List<Product> Product { get; set; }
     
    }
}
