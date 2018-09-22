using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            var _booksRepository = new BooksRepository();
            var _booksList = _booksRepository.GetBooks();
            return View(_booksList);
        }
    }
}