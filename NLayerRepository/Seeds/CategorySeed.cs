using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerCore;


namespace NLayerRepository.Seeds
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Kitaplar" }, new Category { Id = 2, Name = "Kalemler" }, new Category { Id = 3, Name = "Defterler" });
        }
    }
}
