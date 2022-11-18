using Microsoft.AspNetCore.Components;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.MovieGenre
{
    public partial class CreateGenre : IDisposable
    {

        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager navigationManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        Genre genre = new Genre();

       

        private async Task AddGenre()
        {
            _interceptor.MonitorEvent();
            await _client.PostAsJsonAsync(EndPoints.GenresEndpoint, genre);
            navigationManager.NavigateTo("/genre/");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
