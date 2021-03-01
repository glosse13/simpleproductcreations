using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleProductCreation.Domain.Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProductCreation.Infrastructure.Data.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(nameof(Category));
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
        }
    }
}
