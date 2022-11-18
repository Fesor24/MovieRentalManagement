using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.Movies
{
    public partial class MovieIndex : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Movie> movies;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            movies = await _client.GetFromJsonAsync<List<Movie>>(EndPoints.MoviesEndpoint);
        }

        private async Task Delete(int id)
        {
            var movie = movies.First(x => x.Id == id);

            var result = await js.InvokeAsync<bool>("confirm", $"Are you sure you want to delete {movie.MovieRecordNumber}");

            if (result)
            {
                _interceptor.MonitorEvent();
                await _client.DeleteAsync($"{EndPoints.MoviesEndpoint}{id}");
                await OnInitializedAsync();
            }
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
