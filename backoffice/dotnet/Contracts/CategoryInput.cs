using dotnet.Models.Enums;

namespace dotnet.Contracts
{
    public class CategoryInput
    {
        public string Name { get; set; }
        public CategoryType Type { get; set; }
    }
}