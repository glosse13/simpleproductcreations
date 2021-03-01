using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProductCreation.Core 
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
