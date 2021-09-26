using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet.Models.ModelBuilders
{
    public static class ProductBrandBuilder
    {
        public static void Build(this EntityTypeBuilder<ProductBrand> builder)
        {
            // set key here
            builder.HasKey(p => new { p.ProductId, p.BrandId });

            // set relationship 
            builder.HasOne(p => p.Product).WithMany(p => p.ProductBrands);
            builder.HasOne(p => p.Brand).WithMany(p => p.ProductBrands);
        }
    }
}