using MovieSearch.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.Infrastructure.Clients
{
    public class MovieApiClient : IMovieApiClient
    {
        private readonly HttpClient _httpClient;

        public MovieApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ExternalMovieDTO>> FetchMoviesAsync()
        {
            try
            {
                var movies = await _httpClient.GetFromJsonAsync<IEnumerable<ExternalMovieDTO>>("https://data.sfgov.org/resource/yitu-d5am");

                return movies ?? new List<ExternalMovieDTO>();
            }
            catch (Exception ex)
            {
                return new List<ExternalMovieDTO>();
            }
        }
    }
}
