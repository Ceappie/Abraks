using Microsoft.AspNetCore.Mvc;

namespace Abraks.Web.Areas.Dancer.Controllers
{
    public class HistoryController : DancerController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}