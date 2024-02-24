using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission07_Purnell.Models;
using System.Diagnostics;

namespace Mission07_Purnell.Controllers
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();
            return View("NewMovie", new NewMovie());
        }
        [HttpPost]
        public IActionResult NewMovie(NewMovie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName).ToList();
                return View(response);
            }
            
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("NewMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(NewMovie updatedinfo)
        {
            _context.Update(updatedinfo);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(NewMovie record)
        {
            _context.Movies.Remove(record);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
