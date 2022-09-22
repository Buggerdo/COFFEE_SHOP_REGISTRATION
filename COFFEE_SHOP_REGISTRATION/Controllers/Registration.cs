using COFFEE_SHOP_REGISTRATION.Models;
using Microsoft.AspNetCore.Mvc;

namespace COFFEE_SHOP_REGISTRATION.Controllers
{
    public class Registration : Controller
    {
        private CoffeeShopRegistrationDbContext context = new CoffeeShopRegistrationDbContext();

        public IActionResult CreateUser()
        {
            return View();
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
