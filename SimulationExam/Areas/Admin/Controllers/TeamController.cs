using Microsoft.AspNetCore.Mvc;

namespace SimulationExam.Areas.Admin.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
