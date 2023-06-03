using Microsoft.AspNetCore.Mvc;

namespace Market_Place.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
