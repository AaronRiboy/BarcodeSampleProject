using BarcodeSampleProject.Data;
using BarcodeSampleProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BarcodeSampleProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<ProductViewModel> productList = _dbContext.Product;

            return View();
        }

        [HttpPost]
        public IActionResult GetProductDetails(string scannedBarCode)
        {
            var scannedProduct = _dbContext.Product.FirstOrDefault(x => x.Barcode_value == scannedBarCode);

            if (scannedProduct != null)
            {
                return Json(scannedProduct);
            }
            else
            {
                return Json("error");
            }

        }

        public IActionResult DisplayProductDetails(string id)
        {
            return View();
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
