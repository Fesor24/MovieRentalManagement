using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MovieRentalManagement.Server.Models;
using MovieRentalManagement.Shared.Domain;
using System.Reflection;

namespace MovieRentalManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Movie> Movies => Set<Movie>();

        public DbSet<Customer> Customers => Set<Customer>();

        public DbSet<Booking> Bookings => Set<Booking>();

        public DbSet<Industry>? Industries => Set<Industry>();

        public DbSet<Genre>? Genres => Set<Genre>();

    }
}