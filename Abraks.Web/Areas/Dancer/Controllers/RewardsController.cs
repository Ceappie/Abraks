using Microsoft.AspNetCore.Mvc;

namespace Abraks.Web.Areas.Dancer.Controllers
{
    using System.Threading.Tasks;
    using Common.Admin.BindingModels.Rewards;
    using Services.Admin.Interfaces;

    public class RewardsController : DancerController
    {
        private readonly IAdminRewardService rewardsService;

        public RewardsController(IAdminRewardService rewardsService)
        {
            this.rewardsService = rewardsService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var rewards = await this.rewardsService.GetRewards();
            return View(rewards);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(RewardAddingBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            int id = await this.rewardsService.AddReward(model);

            return RedirectToAction("Details", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await this.rewardsService.GetRewardDetails(id);

            return View(model);
        }
    }
}