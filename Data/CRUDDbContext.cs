using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data
{
    internal class CRUDDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Saifaldin\\SQLEXPRESS02;database=CRUDTask;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
