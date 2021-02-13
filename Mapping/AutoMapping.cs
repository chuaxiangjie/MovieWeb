using AutoMapper;
using MovieWeb.Services.Models;

namespace MovieWeb.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<MovieWeb.Services.Models.PosterArt, MovieWeb.Models.PosterArt>();
            CreateMap<MovieWeb.Services.Models.Image, MovieWeb.Models.Image>();
            CreateMap<MovieModel, MovieViewModel>();
        }
    }
}
