using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotnet.Models.ModelBuilders
{
    public static class BrandBuilder
    {
        public static void Build(this EntityTypeBuilder<Brand> builder)
        {
            // set key here
            builder.HasKey(b => b.Id);

            // set relationship 
            builder.HasMany(p => p.ProductBrands).WithOne(pb => pb.Brand);
        }
    }
}