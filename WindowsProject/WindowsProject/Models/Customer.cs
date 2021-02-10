using System;

namespace WindowsProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        public int CreatedUserId { get; set; }
        public int ProductId { get; set; }

        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("CreatedUserId")]
        public virtual User User { get; set; }
        public Product Product { get; set; }
    }

}
