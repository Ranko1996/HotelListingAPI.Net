using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListingAPI.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Jamaica",
                        ShortName = "JM"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Croatia",
                        ShortName = "HR"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Canada",
                        ShortName = "CA"
                    },
                    new Country
                    {
                        Id = 4,
                        Name = "Australia",
                        ShortName = "AU"
                    },
                    new Country
                    {
                        Id = 5,
                        Name = "Japan",
                        ShortName = "JP"
                    }
                );
        }
    }
}