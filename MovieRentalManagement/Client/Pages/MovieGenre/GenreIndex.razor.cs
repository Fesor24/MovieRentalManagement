using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MovieRentalManagement.Client.Services;
using MovieRentalManagement.Client.Static;
using MovieRentalManagement.Shared.Domain;
using System.Net.Http.Json;

namespace MovieRentalManagement.Client.Pages.MovieGenre
{
    public partial class GenreIndex : IDisposable
    {
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpClient _client { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Genre> genres;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            genres = await _client.GetFromJsonAsync<List<Genre>>(EndPoints.GenresEndpoint);

        }

        private async Task Delete(int id)
        {
            var genre = genres.First(x => x.Id == id);

            if (await js.InvokeAsync<bool>("confirm", $"Do you want to delete {genre.Name}?"))
            {
                _interceptor.MonitorEvent();
                await _client.DeleteAsync($"{EndPoints.GenresEndpoint}{id}");
                await OnInitializedAsync();
            }


        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
