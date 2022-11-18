using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.Bookings
{
    public partial class BookingIndex : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Booking> bookings = new List<Booking>();

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            bookings = await _client.GetFromJsonAsync<List<Booking>>(EndPoints.BookingEndpoint);
        }

        private async Task Delete(int id)
        {
            var booking = bookings.First(x => x.Id == id);

            var result = await js.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {booking.Id}");

            if (result)
            {
                _interceptor.MonitorEvent();
                await _client.DeleteAsync($"{EndPoints.BookingEndpoint}{id}");
                await OnInitializedAsync();
            }
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
