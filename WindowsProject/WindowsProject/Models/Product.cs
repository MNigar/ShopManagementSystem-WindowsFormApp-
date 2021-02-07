using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProject.Models
{
    public class Product
    {
        public Product()
        {
           
            LogProduct = new List<LogProduct>();

          
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public User User { get; set; }
        public int CreatedUserId   { get; set; }
        public string PhoneNumber { get; set; }
        public int Count { get; set; }
        public int Status { get; set; }
        public int SoldedCount { get; set; }
        public int SoldedTotal { get; set; }      
        public List<LogProduct> LogProduct { get; set; }



    }
}
