using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skinet.Library.Entities;

namespace Skinet.Infrastructure.Configs
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Description).IsRequired().HasMaxLength(500);
            builder.Property(s => s.ProductUrl).IsRequired();
            builder.Property(s => s.Prise).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(s => s.ProductBrand).WithMany()
                .HasForeignKey(s => s.ProductBrandId);
            builder.HasOne(s => s.ProductType).WithMany()
                .HasForeignKey(s => s.ProductTypeId);
        }
    }
    
    public class ProductBrandConfiguration : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
        }
    }
    
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.Property(s => s.Id).IsRequired();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(100);
        }
    }
}