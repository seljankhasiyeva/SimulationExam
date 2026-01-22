using Microsoft.EntityFrameworkCore;
using SimulationExam.Models;

namespace SimulationExam.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Team> TeamMembers { get; set; }  
        
    }
}
