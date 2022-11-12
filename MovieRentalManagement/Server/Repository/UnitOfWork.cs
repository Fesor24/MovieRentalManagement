using MovieRentalManagement.Server.Data;
using MovieRentalManagement.Server.IRepository;
using MovieRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace MovieRentalManagement.Server.Repository
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private IGenericRepository<Movie> _movieRepository;

        private IGenericRepository<Genre> _genreRepository;
        private IGenericRepository<Industry> _industryRepository;
        private IGenericRepository<Booking> _bookingRepository;
        private IGenericRepository<Customer> _customerRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Movie> MovieRepository => _movieRepository ??= new GenericRepository<Movie>(_context);
        public IGenericRepository<Genre> GenreRepository => _genreRepository ??= new GenericRepository<Genre>(_context);

        public IGenericRepository<Industry> IndustryRepository => _industryRepository ??= new GenericRepository<Industry>(_context);

        public IGenericRepository<Booking> BookingRepository => _bookingRepository ??= new GenericRepository<Booking>(_context);

        public IGenericRepository<Customer> CustomerRepository => _customerRepository ??= new GenericRepository<Customer>(_context);

        public async Task Complete(HttpContext httpContext)
        {

            var user = httpContext.User.Identity.Name;

            var entries = _context.ChangeTracker.Entries().
                Where(x => x.State == EntityState.Modified ||
                x.State == EntityState.Added);

            foreach(var entry in entries)
            {
                ((BaseClass)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseClass)entry.Entity).CreatedBy = user;

                if(entry.State == EntityState.Added)
                {
                    ((BaseClass)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseClass)entry.Entity).CreatedBy = user;
                }
            }
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
