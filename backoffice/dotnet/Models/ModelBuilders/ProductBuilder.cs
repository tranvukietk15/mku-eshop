using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet.Models.ModelBuilders
{
    public static class ProductBuilder
    {
        public static void Build(this EntityTypeBuilder<Product> builder)
        {
            // set key here
            builder.HasKey(p => p.Id);

            // set relationship 
            builder.HasMany(p => p.ProductBrands).WithOne(pb => pb.Product);

            // set annotation here
            builder.Property(p => p.Name).HasMaxLength(350);
        }
    }
}