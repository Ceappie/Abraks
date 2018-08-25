using Microsoft.AspNetCore.Mvc;

namespace Abraks.Web.Areas.Admin.Controllers
{
    public class HistoryController : DancerController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}