using Microsoft.AspNetCore.Mvc;

namespace Lesson_37.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
