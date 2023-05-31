using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductSales.Models;
using System.Diagnostics;

namespace ProductSales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdventureWorks2019Context adventureWorks2019Context;

        public HomeController(ILogger<HomeController> logger,AdventureWorks2019Context adventureWorks2019Context)
        {
            _logger = logger;
            this.adventureWorks2019Context = adventureWorks2019Context;
        }

        public IActionResult Index()
        {
            var result = (
    from d in adventureWorks2019Context.SalesOrderDetails
    join p in adventureWorks2019Context.Products on d.ProductId equals p.ProductId
    join s in adventureWorks2019Context.ProductSubcategories on p.ProductSubcategoryId equals s.ProductSubcategoryId
    join c in adventureWorks2019Context.ProductCategories on s.ProductCategoryId equals c.ProductCategoryId
    group d by new
    {
        d.ProductId,
        p.Name,
        p.ProductNumber,
        Color = p.Color ?? "No Color",
        SubcategoryName = s.Name,
        CategoryName = c.Name
    } into g
    orderby g.Sum(d => d.OrderQty) descending, g.Sum(d => d.OrderQty * d.UnitPrice) descending
    select new
    {
        g.Key.ProductId,
        ProductName = g.Key.Name,
        g.Key.ProductNumber,
        g.Key.Color,
        ProductSubCategory = g.Key.SubcategoryName,
        ProductCategory = g.Key.CategoryName,
        Total_Qty = g.Sum(d => d.OrderQty),
        Total_Sales_Amount = g.Sum(d => d.OrderQty * d.UnitPrice)
    }
).Take(10).ToList();

            var TopSales = result.Take(1).ToList();

            var viewModel = new IndexView
            {
                Result1 = result,
                MaxSalesProduct = TopSales
            };


            return View(viewModel);

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