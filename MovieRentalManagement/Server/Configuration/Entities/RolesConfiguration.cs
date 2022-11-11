using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieRentalManagement.Server.Configuration.Entities
{
    public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "3409cb81-4ee3-48e9-bd08-5e89fec60b74",
                    Name = "User",
                    NormalizedName = "USER"
                },

                new IdentityRole
                {
                    Id= "9009pr81-4ee3-48e9-dc08-5e89fec60b74",
                    Name ="Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }


                ) ;
        }
    }
}
