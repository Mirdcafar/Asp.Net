using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication7.Models.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Title);

            builder.HasData(new List<Category>
            {
                new Category {Id = 1 , Title = "Azerbaycan"},
                new Category {Id = 2, Title = "Ukraine"},
                new Category {Id = 3,Title = "Japanies"},
                new Category {Id = 4, Title = "Italian"}

            });
        }

    }
}
