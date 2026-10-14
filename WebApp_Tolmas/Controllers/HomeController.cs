using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApp_Tolmas.Models;

namespace WebApp_Tolmas.Controllers {
    public class HomeController : Controller {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            var students = _context.Students
                .Include(s => s.Classroom)
                    .ThenInclude(c => c.School)
                .ToList();

            return View(students);
        }

        public IActionResult Privacy() {
            return View();
        }
    }
}