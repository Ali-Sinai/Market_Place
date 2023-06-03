using Microsoft.AspNetCore.Mvc;

namespace Market_Place.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
