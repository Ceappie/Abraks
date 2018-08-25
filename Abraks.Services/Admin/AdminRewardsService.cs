namespace Abraks.Services.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Common.Admin.BindingModels.Rewards;
    using Common.Admin.ViewModels.Rewards;
    using Data;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class AdminRewardsService : BaseAbraksService, IAdminRewardService
    {
        public AdminRewardsService(AbraksContext dbContext, IMapper mapper)
            : base(dbContext, mapper) { }

        public async Task<int> AddReward(RewardAddingBindingModel model)
        {
            Event @event = DbContext.Events.FirstOrDefault(e => e.Name == model.Event);

            if (@event == null)
            {
                throw new ArgumentException();
            }

            Reward reward = new Reward()
            {
                Name = model.Name,
                Description = model.Description,
                EventId = @event.Id,
                ImageUrl = model.ImageUrl
            };

            await this.DbContext.Rewards.AddAsync(reward);
            await this.DbContext.SaveChangesAsync();

            return reward.Id;
        }

        public async Task<IEnumerable<RewardsViewModel>> GetRewards()
        {
            List<Reward> events = await this.DbContext.Rewards.ToListAsync();
            IEnumerable<RewardsViewModel> modelRewards = this.Mapper.Map<IEnumerable<RewardsViewModel>>(events);
            return modelRewards;
        }

        public async Task<RewardDetailsViewModel> GetRewardDetails(int id)
        {
            Reward reward = await this.DbContext.Rewards
                .Include(e => e.Event)
                .FirstOrDefaultAsync(e => e.Id == id);

            Event @event = DbContext.Events.FirstOrDefault(e => e.Id == reward.EventId);

            if (@event == null)
            {
                throw new ArgumentNullException();
            }

            var model = new RewardDetailsViewModel()
            {
                Name = reward.Name,
                Description = reward.Description,
                Event = @event.Name,
                ImageUrl = reward.ImageUrl

            };

            return model;
        }
    }
}
