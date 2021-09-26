using System;
using System.ComponentModel.DataAnnotations;
using dotnet.Models.Enums;

namespace dotnet.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}