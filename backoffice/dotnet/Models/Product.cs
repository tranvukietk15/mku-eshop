using System;
using System.Collections.Generic;
using dotnet.Models.Enums;

namespace dotnet.Models
{
    public class Product : BaseModel
    {
        public Product(string name) : base(name)
        {
        }
        
        public ProductStatus Status { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<ProductBrand> ProductBrands { get; set; }
    }
}