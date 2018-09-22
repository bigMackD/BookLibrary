using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class BooksController : Controller
    {
        static BooksRepository _booksRepository = new BooksRepository();
        static List<Book> _booksList = _booksRepository.GetBooks();

        public IActionResult Index()
        {
            return View(_booksList);
        }

        public IActionResult Details(int id)
        {
            return View(_booksRepository.GetBook(id));
        }
    }
}