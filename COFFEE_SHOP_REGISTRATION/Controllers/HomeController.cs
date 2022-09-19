using COFFEE_SHOP_REGISTRATION.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COFFEE_SHOP_REGISTRATION.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CoffeeShopRegistrationDbContext context = new CoffeeShopRegistrationDbContext();

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

        public IActionResult CreateUser()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult AddUserToDb(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return RedirectToAction("WelcomeNewUser", user);
        }

        public IActionResult WelcomeNewUser(User user)
        {
            //Registration user = context.Registrations.ToList().LastOrDefault();
            return View(user);
        }    
    }
}