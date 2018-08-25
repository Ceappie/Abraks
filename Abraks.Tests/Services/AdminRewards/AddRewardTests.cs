namespace Abraks.Tests.Services.AdminRewards
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Abraks.Services.Admin;
    using Common.Admin.BindingModels.Rewards;
    using Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using Models;

    [TestClass]
    public class AddRewardTests
    {
        private AbraksContext context;
        private AdminRewardsService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.context = MockDbContext.GetContext();
            this.service = new AdminRewardsService(context, MockAutoMapper.GetMapper());

            CreateInitialEvents();
        }

        [TestMethod]
        public async Task AddReward_WithCorrectReward_ShouldWorkProperly()
        {
            const string name = "Reward Testing Name";
            const string description = "Rewards Description";

            var rewardModel = new RewardAddingBindingModel()
            {
                Name = "Reward Testing Name",
                Description = "Rewards Description",
                ImageUrl = "https://dveri.bg/cache/new5/6/1687d8c0fb11c8f4e2a1d603e65e6e1a.png",
                Event = "Gergiovden"
            };

            await this.service.AddReward(rewardModel);
            var reward = this.context.Rewards.First();

            Assert.AreEqual(name, reward.Name);
            Assert.AreEqual(description, reward.Description);
        }

        [TestMethod]
        public async Task AddReward_WithCorrectFewReward_ShouldAddProperly()
        {
            var firstRewardModel = new RewardAddingBindingModel()
            {
                Name = "First Reward Testing Name",
                Description = "Rewards Description",
                ImageUrl = "https://dveri.bg/cache/new5/6/1687d8c0fb11c8f4e2a1d603e65e6e1a.png",
                Event = "Gergiovden"
            };

            var secondRewardModel = new RewardAddingBindingModel()
            {
                Name = "Second Reward Testing Name",
                Description = "Second Rewards Description",
                ImageUrl = "https://dveri.bg/cache/new5/6/1687d8c0fb11c8f4e2a1d603e65e6e1a.png",
                Event = "Gergiovden"
            };

            await this.service.AddReward(firstRewardModel);
            await this.service.AddReward(secondRewardModel);

            Assert.AreEqual(2, this.context.Rewards.Count());
        }

        [TestMethod]
        public async Task AddReward_WithNullReward_ShouldThrowException()
        {
            RewardAddingBindingModel rewardModel = null;

            await Assert.ThrowsExceptionAsync<InvalidOperationException>(
                () => this.service.AddReward(rewardModel));
        }

        private void CreateInitialEvents()
        {
            DanceType dance = (new DanceType()
            {
                Name = "Folklor"
            });

            this.context.Events.Add(new Event()
            {
                Name = "Gergiovden",
                Place = "Stefanovo",
                Address = "Stefanovo",
                Dance = dance,
                PosterUrl = "https://imageshack.com/a/img924/5145/O5s8hO.jpg",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(2)
            });

            this.context.Events.Add(new Event()
            {
                Name = "Trakia",
                Place = "Plovdiv",
                Address = "Plovdiv20",
                Dance = dance,
                PosterUrl = "https://imageshack.com/a/img924/5145/O5s8hO.jpg",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(2)
            });

            this.context.SaveChanges();
        }
    }
}
