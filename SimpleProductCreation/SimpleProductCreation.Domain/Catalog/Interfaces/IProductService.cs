using SimpleProductCreation.Domain.Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductCreation.Domain.Catalog.Interfaces
{
    public interface IProductService
    {
        public Product CreateProduct(string productName, Guid categoryId);
        public List<Product> GetProductList();
        public List<Product> GetCategoryProductList(Guid categoryId);
        public Product GetProduct(Guid productId);
    }
}
