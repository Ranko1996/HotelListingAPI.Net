using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
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
            modelBuilder.Entity<Hotel>().HasData(
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
