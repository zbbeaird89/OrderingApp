using System;
using Microsoft.EntityFrameworkCore;
using API.Entities;


namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base()
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
