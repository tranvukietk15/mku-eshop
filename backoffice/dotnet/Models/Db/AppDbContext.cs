using dotnet.Models.ModelBuilders;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Models.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Add DbSet Here
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        
        /// <summary>
        /// You can modify builder here
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().Build();
            builder.Entity<Category>().Build();
            builder.Entity<Brand>().Build();
            builder.Entity<ProductBrand>().Build();

            base.OnModelCreating(builder);
        }
    }
}