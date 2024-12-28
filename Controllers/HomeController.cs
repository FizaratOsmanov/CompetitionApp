using Microsoft.AspNetCore.Mvc;

namespace CompetitionApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
