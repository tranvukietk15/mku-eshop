using System.Collections.Generic;

namespace dotnet.Models.SeedData
{
    public static class Seed
    {
        public static IEnumerable<Category> Categories =>
            new List<Category>
            {
                new Category("TShirt"),
                new Category("Shirt"),
            };
    }
}