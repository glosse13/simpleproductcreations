using SimpleProductCreation.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SimpleProductCreation.Domain.Catalog.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        [NotMapped]
        public List<Product> Products { get; set;}
        public Category()
        {

        }

        private Category(string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
        }
        public static Category CreateCategory(string name) => new Category(name);
    }
}
