using SimpleProductCreation.Domain.Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProductCreation.Domain.Catalog.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
