using Eve.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Eve.Core.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(UserDataViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
