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
    public class IndustryConfiguration : IEntityTypeConfiguration<Industry>
    {
        public void Configure(EntityTypeBuilder<Industry> builder)
        {
            builder.HasData(

                new Industry
                {
                    Id=1,
                    Name = "K-drama",
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    UpdatedBy = "System"
                },

                 new Industry
                 {
                     Id=2,
                     Name = "Nollywood",
                     CreatedBy = "System",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     UpdatedBy = "System"
                 },

                  new Industry
                  {
                      Id=3,
                      Name = "Bollywood",
                      CreatedBy = "System",
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      UpdatedBy = "System"
                  },

                   new Industry
                   {
                       Id=4,
                       Name = "Hollywood",
                       CreatedBy = "System",
                       DateCreated = DateTime.Now,
                       DateUpdated = DateTime.Now,
                       UpdatedBy = "System"
                   }






                );
        }
    }
}
