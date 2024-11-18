using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCLab07.Areas.Admins.Controllers
{
    public class Category : Controller
    {
        [Area("Admins")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
