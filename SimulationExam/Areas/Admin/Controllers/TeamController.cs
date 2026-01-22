using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimulationExam.DAL;
using SimulationExam.Models;

namespace SimulationExam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        public readonly AppDbContext _context;
        public TeamController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Team> teamMembers = await _context.TeamMembers.ToListAsync();
            return View(teamMembers);
        }
    }
}
