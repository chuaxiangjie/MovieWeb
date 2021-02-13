using AutoMapper;
using MovieWeb.Services.Models;

namespace MovieWeb.ClientApp.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<MovieWeb.Services.Models.PosterArt, MovieWeb.ClientApp.Models.PosterArt>();
            CreateMap<MovieWeb.Services.Models.Image, MovieWeb.ClientApp.Models.Image>();
            CreateMap<MovieModel, MovieViewModel>();
        }
    }
}
