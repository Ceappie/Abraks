namespace Abraks.Web.Areas.Admin.Controllers
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    
    public class HomeController : DancerController
    {
        public IActionResult Index()
        {
            return View("Index");
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