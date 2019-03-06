using ChiSell.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChiSell.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasOne(u => u.ParentCategory).WithMany(u => u.Categories).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
