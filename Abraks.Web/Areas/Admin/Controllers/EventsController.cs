namespace Abraks.Web.Areas.Admin.Controllers
{
    using System.Threading.Tasks;
    using Common.Admin.BindingModels.Events;
    using Microsoft.AspNetCore.Mvc;
    using Services.Admin.Interfaces;

    public class EventsController : DancerController
    {
        private readonly IAdminEventsService eventsService;

        public EventsController(IAdminEventsService eventsService)
        {
            this.eventsService = eventsService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var events = await this.eventsService.GetEvents();
            return View(events);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventAddingBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

             int id = await this.eventsService.AddEvent(model);

            return RedirectToAction("Details", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await this.eventsService.GetEventDetails(id);
            return View(model);
        }
    }
}
