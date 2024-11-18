using Lab_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_03.Controllers
{
    public class BookController : Controller
    {
        protected Book book=new Book();
        public IActionResult Index()
        {
            ViewBag.authors = book.Athors;
            ViewBag.genders=book.Genders;
            var books =book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.authors = book.Athors;
            ViewBag.genders = book.Genders;
            var books = new Book();
            return View(model);
        }
    }
}
