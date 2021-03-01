using Microsoft.EntityFrameworkCore;
using SimpleProductCreation.Domain.Catalog.Entities;
using SimpleProductCreation.Infrastructure.Data.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProductCreation.Infrastructure.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
