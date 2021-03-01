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
    public class CategoryService : ICategoryService
    {
        private readonly IAsyncRepository<Category> categoryRepository;

        public CategoryService(IAsyncRepository<Category> categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public List<Category> GetCategories()
        {
            return categoryRepository.ListAll().ToList();
        }
    }
}
