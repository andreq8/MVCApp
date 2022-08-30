using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            var dog = new DogViewModel { Name = "dog", Age = 5 };
            return View(dog);
        }
        public IActionResult Hello()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
