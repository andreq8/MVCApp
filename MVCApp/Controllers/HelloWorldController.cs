using Microsoft.AspNetCore.Mvc;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "this is the hello world page";
        }
        public string Hello()
        {
            return "Hello cruel world!";
        }
    }
}
