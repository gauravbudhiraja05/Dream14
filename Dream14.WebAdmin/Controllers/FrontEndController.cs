using Microsoft.AspNetCore.Mvc;

namespace Dream14.WebAdmin.Controllers
{
    public class FrontEndController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}