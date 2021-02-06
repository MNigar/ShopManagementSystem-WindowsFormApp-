using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.DataAccessLayer;

namespace WindowsProject.Models
{
    public class User
    {
        public User()
        {
            Products = new List<Product>();
            LogProduct = new List<LogProduct>();
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public List<Product> Products { get; set; }
        public List<LogProduct> LogProduct { get; set; }
     
    }
}
