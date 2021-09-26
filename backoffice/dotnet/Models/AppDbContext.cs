using Microsoft.EntityFrameworkCore;

namespace dotnet.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().Property(x => x.Name).HasMaxLength(350);
            // builder.Entity<Category>().Property(x => x.Name).HasMaxLength(350);

            base.OnModelCreating(builder);
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}