using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Controllers
{
    public class BooksController : Controller
    {
        static BooksRepository _booksRepository = new BooksRepository();
        static List<Book> _booksList = _booksRepository.GetBooks();
        private GenresRepository _genresRepository = new GenresRepository();

        public IActionResult Index()
        {
            return View(_booksList);
        }

        public IActionResult Details(int id)
        {
            return View(_booksRepository.GetBook(id));
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            var newBookId = _booksRepository.AddBook(book);
            return RedirectToAction("Details", new { id = newBookId });
           
        }

        public IActionResult Create()
        {
            ViewBag.Genres = _genresRepository.GetAll()
                .Select(x =>
                new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString()
                });
            return View();
        }
    }
}