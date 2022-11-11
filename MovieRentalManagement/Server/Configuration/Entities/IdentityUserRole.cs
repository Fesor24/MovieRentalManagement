using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieRentalManagement.Server.Configuration.Entities
{
    public class IdentityUserRole : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "9009pr81-4ee3-48e9-dc08-5e89fec60b74",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                }
                
                
                );
        }
    }
}
