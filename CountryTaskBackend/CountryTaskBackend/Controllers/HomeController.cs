using Microsoft.AspNetCore.Mvc;

namespace CountryTaskBackend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(int id, string name)
        {
            return Content($"{id}) {name} | Haqqimizda {RandomId()}");
        }

        [NonAction]
        public string RandomId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
