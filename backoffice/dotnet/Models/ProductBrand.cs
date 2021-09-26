using System;

namespace dotnet.Models
{
    public class ProductBrand
    {
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}