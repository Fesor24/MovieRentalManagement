using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieRentalManagement.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagement.Server.Configuration.Entities
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id=1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Action",
                    UpdatedBy = "System"

                },

                   new Genre
                   {
                       Id=2,
                       CreatedBy = "System",
                       DateCreated = DateTime.Now,
                       DateUpdated = DateTime.Now,
                       Name = "Drama",
                       UpdatedBy = "System"

                   },
                      new Genre
                      {
                          Id=3,
                          CreatedBy = "System",
                          DateCreated = DateTime.Now,
                          DateUpdated = DateTime.Now,
                          Name = "Sci-Fi",
                          UpdatedBy = "System"

                      },
                         new Genre
                         {
                             Id=4,
                             CreatedBy = "System",
                             DateCreated = DateTime.Now,
                             DateUpdated = DateTime.Now,
                             Name = "Romance",
                             UpdatedBy = "System"

                         }



                );
        }
    }
}
