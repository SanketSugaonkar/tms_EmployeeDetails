using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using WebApplication1.Entites;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        db d= new db();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind] Ad_login ad)
        {
            
            int res = d.LoginCheck(ad);
            if (res == 1)
            {
                TempData["msg"] = "Welcome to Admin page";

            }
            else
            {
                TempData["msg"] = "Admin Id or Password is Wrong";
            }
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