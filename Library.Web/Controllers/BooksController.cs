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
        private GenresRepository _genresRepository = new GenresRepository();

        public IActionResult Index()
        {
            var booksList = _booksRepository.GetBooks();
            return View(booksList);
        }

        public IActionResult Details(int id)
        {
            return View(_booksRepository.GetBook(id));
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                var newBookId = _booksRepository.AddBook(book);
                return RedirectToAction("Details", new { id = newBookId });
            }
            ViewBag.Genres = _genresRepository.GetAll()
                   .Select(x =>
                   new SelectListItem
                   {
                       Text = x.Name,
                       Value = x.Id.ToString()
                   });
            return View(book);
           
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

        [HttpPost]
        public IActionResult Update(Book book)
        {
            _booksRepository.UpdateBook(book);
            return RedirectToAction("Details", new { book.Id });
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Genres = _genresRepository.GetAll()
              .Select(x =>
              new SelectListItem
              {
                  Text = x.Name,
                  Value = x.Id.ToString()
              });
            var bookToUpdate = _booksRepository.GetBook(id);
            return View(bookToUpdate);
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            ViewBag.Genres = _genresRepository.GetAll()
               .Select(x =>
               new SelectListItem
               {
                   Text = x.Name,
                   Value = x.Id.ToString()
               });
            var book = _booksRepository.GetBook(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Remove(Book book)
        {

            _booksRepository.RemoveBook(book);
            return RedirectToAction("Index");

        }
    }
}