using MovieWeb.Services.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieWeb.Services
{
    public interface IMovieService
    {
        Task<List<MovieModel>> GetMovies(string title, int lastItemIndex);
    }
}
