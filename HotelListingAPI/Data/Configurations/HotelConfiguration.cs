using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net;

namespace HotelListingAPI.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(

                  new Hotel
                  {
                      Id = 1,
                      Name = "Hotel Jamaica",
                      Address = "123 Beach Road, Kingston",
                      CountryId = 1,
                      Rating = 4.5
                  },
                  new Hotel
                  {
                      Id = 2,
                      Name = "Hotel Croatia",
                      Address = "456 Coastal Avenue, Dubrovnik",
                      CountryId = 2,
                      Rating = 4.8
                  },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Hotel Canada",
                      Address = "789 Maple Street, Toronto",
                      CountryId = 3,
                      Rating = 4.7
                  },
                  new Hotel
                  {
                      Id = 4,
                      Name = "Hotel Australia",
                      Address = "101 Kangaroo Lane, Sydney",
                      CountryId = 4,
                      Rating = 4.6
                  },
                  new Hotel
                  {
                      Id = 5,
                      Name = "Hotel Japan",
                      Address = "202 Sakura Blvd, Tokyo",
                      CountryId = 5,
                      Rating = 4.9
                  }
                );
        }
    }
}