using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {

        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
    }
}
