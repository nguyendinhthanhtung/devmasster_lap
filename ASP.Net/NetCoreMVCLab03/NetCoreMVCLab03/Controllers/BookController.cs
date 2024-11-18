using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab03.Models;
using System.Reflection;

namespace NetCoreMVCLab03.Controllers
{ 
    public class BookController : Controller
    {
      
       
            protected Book book = new Book();
            public IActionResult Index()
            {
                ViewBag.authors = book.Athors;
                ViewBag.genders = book.Genders;
                var books = book.GetBookList();
                return View(books);
            }
            public IActionResult Create()
            {
                ViewBag.authors = book.Athors;
                ViewBag.genders = book.Genders;
                var model = new Book();
                return View(model);
            }
            public IActionResult Edit (int id) 
            {
                ViewBag.authors = book.Athors;
                ViewBag.genders = book.Genders;
                var model = book.GetBookById(id);
                return View(model);
            }
    }
}
    

