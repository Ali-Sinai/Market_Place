using Microsoft.AspNetCore.Mvc;

namespace Market_Place.Controllers
{
    public class SalesManController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
