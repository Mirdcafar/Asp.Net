using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Shop.Models.Configuration
{
    public class CountryConfiguration :IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(x => x.CountryName);

            builder.HasData(new List<Country>
            {
                new Country {Id = 1 , CountryName = "Azerbaycan"},
                new Country {Id = 2, CountryName = "Ukraine"},
                new Country {Id = 3,CountryName = "Japanies"},
                new Country {Id = 4, CountryName = "Italian"}
            });
        }
    }
}
