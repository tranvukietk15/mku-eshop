using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using dotnet.Models.Enums;

namespace dotnet.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        public CategoryType Type { get; set; }
        public List<Product> Products { get; set; }
    }
}