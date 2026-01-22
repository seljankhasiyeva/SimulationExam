using Microsoft.AspNetCore.Mvc;
using SimulationExam.DAL;
using System.Diagnostics;
using SimulationExam.Models;
using SimulationExam.ViewModels;


namespace SimulationExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                TeamMembers=_context.TeamMembers.ToList()
            };
            return View(homeVM);
        }

    }
}