using AituFood.Models;
using AituFood.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AituFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository _homeRepository;

        public HomeController(ILogger<HomeController> logger , IHomeRepository homeRepository)
        {
            _logger = logger;
            _homeRepository = homeRepository;
        }

        public async Task<IActionResult> Index(string sterm="", int categotyId=0)
        {

            
            IEnumerable<Product> products = await _homeRepository.GetProducts(sterm, categotyId);
            IEnumerable<Category> categories = await _homeRepository.Categorys();
            ProductDisplayModel productModel = new ProductDisplayModel
            {
                Products = products,
                Categorys = categories,
                STerm = sterm,
                CategoryId=categotyId,
            };


            return View(productModel);
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
