using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment2.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly DBContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DBContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            List<StudentDetails> students = _context.Students.ToList();
            return View(students);
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