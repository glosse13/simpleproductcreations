using Microsoft.EntityFrameworkCore;
using SimpleProductCreation.Core;
using SimpleProductCreation.Domain.Catalog.Entities;
using SimpleProductCreation.Domain.Catalog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductCreation.Domain.Catalog.Services
{
    public class ProductService : IProductService
    {
        private readonly IAsyncRepository<Category> categoryRepository;
        private readonly IAsyncRepository<Product> productRepository;

        public ProductService(IAsyncRepository<Category> categoryRepository, IAsyncRepository<Product> productRepository)
        {
            this.categoryRepository = categoryRepository;
            this.productRepository = productRepository;
        }

        public Product CreateProduct(string productName,Guid categoryId)
        {
            if (categoryId == null)             
                throw new Exception("Kategori Id Null Girildi");
            Category category = categoryRepository.Get(x => x.Id == categoryId).FirstOrDefault();
            if (category == null)
                throw new Exception("Kategori Bulunamadı");
            Product product = Product.CreateProduct(productName, categoryId);
            return productRepository.Add(product);
        }

        public Product GetProduct(Guid productId)
        {
            if (productId == null)
                throw new Exception("Ürün Id Boş Bırakılmamalı");
            Product product = productRepository.Get(x => x.Id == productId).Include(x => x.Category).FirstOrDefault();
            if (product == null)
                throw new Exception("Ürün Bulunamadı");
            return product;
        }

        public List<Product> GetProductList()
        {
            return productRepository.ListAll().ToList();
        }
        public List<Product> GetCategoryProductList(Guid categoryId)
        {
            return productRepository.Get(x=>x.CategoryId==categoryId).ToList();
        }
    }
}
