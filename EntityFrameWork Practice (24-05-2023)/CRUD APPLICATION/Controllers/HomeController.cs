using CRUD_APPLICATION.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUD_APPLICATION.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EfDemoDbContext efDemoDbContext;

       public HomeController(ILogger<HomeController> logger,EfDemoDbContext efDemoDbContext)
        {
            _logger = logger;
            this.efDemoDbContext = efDemoDbContext;
        }

        public IActionResult Index()
        {
            var student=efDemoDbContext.Students.ToList();
            foreach(var st in student)
            {
                Console.WriteLine(st.FirstName+" "+st.LastName);
            }
            return View(student);
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