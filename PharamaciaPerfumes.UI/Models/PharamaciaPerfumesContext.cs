using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PharamaciaEntities;
using Users;

namespace PharamaciaPerfumes.UI.Models
{
    public partial class PharamaciaPerfumesContext : DbContext
    {
        
        public PharamaciaPerfumesContext()
        {
        }

        public PharamaciaPerfumesContext(DbContextOptions<PharamaciaPerfumesContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=PC\\SQLEXPRESS;Initial Catalog=PharamaciaPerfumes;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<User>().HasKey(k=>new {k.UserName,k.Password});
            modelBuilder.Entity<Employee>().HasOne(e => e.User);
            modelBuilder.Entity<Order>().HasOne(o => o.Customer).WithMany(c => c.Orders);
            modelBuilder.Entity<Order>().HasMany(o => o.Products);
            modelBuilder.Entity<Customer>().HasOne(c => c.User);

      
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
