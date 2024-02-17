using Microsoft.AspNetCore.Mvc;
using Mission06_Purnell.Models;
using System.Diagnostics;

namespace Mission06_Purnell.Controllers
{
    public class HomeController : Controller
    {
        private NewMovieContext _context;

        public HomeController(NewMovieContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NewMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewMovie(NewMovie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View("Index", response);
        }
    }
}
