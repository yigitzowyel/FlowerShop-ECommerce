using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using yigit2324.Models;

namespace yigit2324.Controllers
{
    public class HomeController : Controller
    {
        CiceksepetiDbContext db=new CiceksepetiDbContext(); 
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var x=db.Urunlers.ToList();
            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Detay(int id)
        {
            var detay=db.Urunlers.FirstOrDefault(x=>x.Id==id);
            return View(detay);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
