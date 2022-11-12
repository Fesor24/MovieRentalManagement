using MovieRentalManagement.Server.Data;
using MovieRentalManagement.Shared.Domain;

namespace MovieRentalManagement.Server.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        IGenericRepository<Movie> MovieRepository { get;}

        IGenericRepository<Genre> GenreRepository { get;}
        IGenericRepository<Industry> IndustryRepository { get; }
        IGenericRepository<Booking> BookingRepository { get; }
        IGenericRepository<Customer> CustomerRepository { get; }

        Task Complete(HttpContext httpContext);
    }
}
