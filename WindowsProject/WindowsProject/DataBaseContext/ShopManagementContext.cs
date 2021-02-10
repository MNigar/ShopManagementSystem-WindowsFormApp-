using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsProject.Models;

namespace WindowsProject.DataBaseContext
{
    public class ShopManagementContext:DbContext
    {
        public ShopManagementContext() : base("ShopApp") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Consumers { get; set; }
        public DbSet<LogProduct> LogProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasMany(t => t.Customers).WithRequired(a => a.User).WillCascadeOnDelete(false); //add this line code
            modelBuilder.Entity<User>().HasMany(t => t.LogProduct).WithRequired(a => a.User).WillCascadeOnDelete(false); //add this line code

        }
    }
}
