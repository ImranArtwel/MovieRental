using System.Collections.Generic;
using System.Web.Mvc;
using MyCSharpMVC.Models;
using MyCSharpMVC.ViewModels;


namespace MyCSharpMVC.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Prison Break" },
                new Movie { Id = 2, Name = "Lion King" }
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Imran Artwel" },
                new Customer { Name = "Piya Artwel" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}