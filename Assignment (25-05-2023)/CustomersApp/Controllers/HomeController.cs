using CustomersApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomersApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CustomerDBContext _dbContext;

        public HomeController(ILogger<HomeController> logger, CustomerDBContext dbContext)
        {
            _logger = logger;
            this._dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var topCustomers = (from cust in this._dbContext.CustomerDetails
                               join purchase in this._dbContext.PurchaseDatas on cust.customerId equals purchase.customerID
                               orderby purchase.TotalPrice descending
                               select new
                               {
                                   cust.customerId,
                                   cust.customerName,
                                   cust.customerAddress,
                                   cust.customerEmail,
                                   purchase.TotalPrice

                               }).Take(10);
            return View(topCustomers);
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