using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IND"
                },
                new Country
                {
                    Id = 2,
                    Name = "Dubai",
                    ShortName = "DXB"
                },
                new Country
                {
                    Id = 3,
                    Name = "Thailand",
                    ShortName = "THD"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort & Spa",
                    Address = "Mumbai",
                    CountryId = 1,
                    Rating = 4.5

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Burj Dubai",
                    Address = "Dubai",
                    CountryId = 2,
                    Rating = 5
                },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Hilton Grand",
                      Address = "Bangkok",
                      CountryId = 3,
                      Rating = 4
                  }
                );

        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
