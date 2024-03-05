using Microsoft.AspNetCore.Mvc;
using recipeWebsite.Models;
using System.Diagnostics;

namespace recipeWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        //GET RECIPES

        /*
         public async Task<IActionResult> Index(int pageNumber=1)
        {
            return View(await PaginatedList<Recipe>.CreateAsync(_context.Recipes, pageNumber, 5));
        }
         
         */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}