using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCLab07.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class Dashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
