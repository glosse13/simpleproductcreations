using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProductCreation.Models
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
    }
}
