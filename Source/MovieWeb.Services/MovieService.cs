using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using MovieWeb.Services.Models;
using MovieWeb.Services.Models.ApiResponse;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieWeb.Services
{
    public class MovieService : IMovieService
    {
        private IHttpClientFactory _httpClientFactory;
        private MovieSettings _movieSettings;

        public MovieService(IHttpClientFactory httpClientFactory, IOptions<MovieSettings> dbOption)
        {
            _httpClientFactory = httpClientFactory;
            _movieSettings = dbOption.Value;
        }

        public async Task<List<MovieModel>> GetMovies(string title, int lastItemIndex)
        {
            var httpClient = _httpClientFactory.CreateClient();

            var apiUrl = _movieSettings.MovieApiUrl + "movies";

            //build query parameters

            if (!string.IsNullOrEmpty(title))
                apiUrl = QueryHelpers.AddQueryString(apiUrl, "title", title);

                apiUrl = QueryHelpers.AddQueryString(apiUrl, "itemindex", lastItemIndex.ToString());

            var response = await httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
               var responseStr = response.Content.ReadAsStringAsync().Result;

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };

                var movieApiResponse = JsonSerializer.Deserialize<MovieResponse<List<MovieModel>>>(responseStr, options);

                return movieApiResponse.Data;
            }
            else
            {
                return null;
            }
        }
    }
}
