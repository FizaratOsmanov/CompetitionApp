using Microsoft.AspNetCore.Mvc;

namespace CompetitionApp.Controllers
{
    public class TopicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
