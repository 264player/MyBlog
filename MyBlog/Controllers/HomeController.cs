using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            List<ABlog> list = new List<ABlog>();
            var blogs = new Blogs()
            {
                BlogList = list,
            };
            return View(blogs);
        }

        public IActionResult Life()
        {
            return View();
        }

        public IActionResult Frends()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Summary()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}