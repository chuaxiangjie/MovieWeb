using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieWeb.ClientApp.Models;
using MovieWeb.Services;
using MovieWeb.Services.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieWeb.ClientApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IHttpClientFactory httpClientFactory, IMapper mapper, IMovieService movieService, ILogger<HomeController> logger)
        {
            _movieService = movieService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetMovies(title: "", lastItemIndex: 0);

            //convert to viewModel

            var movieViewModels = _mapper.Map<List<MovieModel>, List<MovieViewModel>>(movies);

            return View();
        }
   
        [HttpGet]
        public async Task<ActionResult> MovieList([FromQuery] MovieSearchModel movieSearchModel)
        {
            if (!ModelState.IsValid)
                return null;

            var movies = await _movieService.GetMovies(
                title: movieSearchModel.Title,
                lastItemIndex: movieSearchModel.ItemIndex
            );

            //convert to viewModel
            var movieViewModels = _mapper.Map<List<MovieModel>, List<MovieViewModel>>(movies);

            return PartialView("_MovieList", movieViewModels);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
