using System;
using System.Collections.Generic;
using dotnet.Models.Enums;

namespace dotnet.Models
{
    public class Category : BaseModel
    {
        public Category(string name) : base(name)
        {
        }
        
        public CategoryType Type { get; set; }
        public IEnumerable<Product> Products { get; set; }

        private void EnsureUpdate()
        {
            UpdatedOn = DateTime.Now;
        }
        
        internal void UpdateName(string name)
        {
            Name = name;
            EnsureUpdate();
        }
    }
}