using Microsoft.AspNetCore.Components;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.Customers
{
    public partial class CreateCustomers : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Customer customer = new Customer();

        private async Task AddCustomer()
        {
            _interceptor.MonitorEvent();
            await _client.PostAsJsonAsync(EndPoints.CustomerEndpoint, customer);
            navigationManager.NavigateTo("/customer/");

        }
        public void Dispose()
        {

            _interceptor.DisposeEvent();
        }
    }
}
