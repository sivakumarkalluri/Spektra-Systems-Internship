using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentsRanks.Models;
using System.Diagnostics;
using System.Linq;
namespace StudentsRanks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentDatabaseContext studentDatabaseContext; 
        public HomeController(ILogger<HomeController> logger, StudentDatabaseContext studentDatabaseContext)
        {
            _logger = logger;
            this.studentDatabaseContext = studentDatabaseContext;
        }

        public IActionResult Index()
        {
            var topStudents = this.studentDatabaseContext.TopStudents.FromSqlRaw("EXEC GetTop20Students").ToList();
            return View(topStudents);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}