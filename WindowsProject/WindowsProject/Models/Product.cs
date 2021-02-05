using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProject.Models
{
    public class Product
    {   [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public int CreatedUser { get; set; }
        public string PhoneNumber { get; set; }
        public int Count { get; set; }
        public int Status { get; set; }





    }
}
