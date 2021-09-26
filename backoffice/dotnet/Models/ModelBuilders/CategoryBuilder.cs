using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet.Models.ModelBuilders
{
    public static class CategoryBuilder
    {
        public static void Build(this EntityTypeBuilder<Category> builder)
        {
            // set key here
            builder.HasKey(c => c.Id);

            // set annotation here
            builder.Property(c => c.Name).HasMaxLength(350);
        }
    }
}