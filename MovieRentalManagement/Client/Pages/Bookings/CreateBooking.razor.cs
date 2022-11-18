using Microsoft.AspNetCore.Components;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.Bookings
{
    public partial class CreateBooking : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Booking booking = new Booking
        {
            DateOut = DateTime.Now.Date
        };

        List<Customer> customers = new List<Customer>();
        List<Movie> movies = new List<Movie>();

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            customers = await _client.GetFromJsonAsync<List<Customer>>(EndPoints.CustomerEndpoint);
            movies = await _client.GetFromJsonAsync<List<Movie>>(EndPoints.MoviesEndpoint);
        }
        private async Task AddBooking()
        {
            await _client.PostAsJsonAsync(EndPoints.BookingEndpoint, booking);
            navigationManager.NavigateTo("/booking/");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
