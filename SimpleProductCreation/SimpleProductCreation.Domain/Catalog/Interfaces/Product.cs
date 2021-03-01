using SimpleProductCreation.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SimpleProductCreation.Domain.Catalog.Entities
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        [NotMapped]
        public Category Category { get; set; }
        public Product()
        {

        }
        private Product(string name, Guid categoryId)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.CategoryId = categoryId;
        }
        public static Product CreateProduct(string name, Guid categoryId) => new Product(name, categoryId);
    }
}
