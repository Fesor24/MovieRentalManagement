using Microsoft.AspNetCore.Components;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.Movies
{
    public partial class CreateMovie : IDisposable
    {

        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Movie movie = new Movie();
        private List<Genre> genres = new List<Genre>();
        private List<Industry> industries = new List<Industry>();



        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            genres = await _client.GetFromJsonAsync<List<Genre>>(EndPoints.GenresEndpoint);
            industries = await _client.GetFromJsonAsync<List<Industry>>(EndPoints.IndustryEndpoint);
        }

        private async Task AddMovie()
        {
            _interceptor.MonitorEvent();
            await _client.PostAsJsonAsync(EndPoints.MoviesEndpoint, movie);
            navigationManager.NavigateTo("/movie/");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
            
        }
    }
}
