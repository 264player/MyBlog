using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Creat()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
