using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.MovieIndustry
{
    public partial class MovieIndustry: IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Industry> industries;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            industries = await _client.GetFromJsonAsync<List<Industry>>(EndPoints.IndustryEndpoint);
        }

        private async Task Delete(int id)
        {
            var industry = industries.First(x => x.Id == id);

            var result = await js.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {industry.Name}");

            if (result)
            {
                _interceptor.MonitorEvent();
                await _client.DeleteAsync($"{EndPoints.IndustryEndpoint}{id}");
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
