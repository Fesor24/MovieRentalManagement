using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.Customers
{
    public partial class CustomerIndex : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Customer> customers;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            customers = await _client.GetFromJsonAsync<List<Customer>>(EndPoints.CustomerEndpoint);
        }

        private async Task Delete(int id)
        {
            var customer = customers.First(x => x.Id == id);

            var result = await js.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {customer.Id}");

            if (result)
            {
                _interceptor.MonitorEvent();
                await _client.DeleteAsync($"{EndPoints.CustomerEndpoint}{id}");
                await OnInitializedAsync();
            }
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
            
        }
    }
}
