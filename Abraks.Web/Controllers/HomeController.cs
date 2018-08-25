namespace Abraks.Web.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Abraks.Web.Models;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (this.User.IsInRole("Administrator"))
            {
                return View("~/Areas/Admin/Views/Home/Index.cshtml");
            }

            if (this.User.Identity.IsAuthenticated)
            {
                return View("~/Areas/Dancer/Views/Home/Index.cshtml");
            }

            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
