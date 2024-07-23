using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class ContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=CINGIZ\MSSQLSERVER01;Database=Restaurant;Trusted_Connection=true;TrustServerCertificate=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}   
