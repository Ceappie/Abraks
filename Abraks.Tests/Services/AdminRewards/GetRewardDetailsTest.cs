namespace Abraks.Tests.Services.AdminRewards
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Abraks.Services.Admin;
    using Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using Models;

    [TestClass]
    public class GetRewardDetailsTest
    {
        private AbraksContext context;
        private AdminRewardsService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.context = MockDbContext.GetContext();
            this.service = new AdminRewardsService(context, MockAutoMapper.GetMapper());
        }
        
        [TestMethod]
        public async Task GetRewardDetails_WithCorrectDetails_ShouldWorkProperly()
        {
            const string name = "First Place";
            const string description = "Best Performance";

            CreateInitialRewards();

            await this.service.GetRewardDetails(1);
            var reward = this.context.Rewards.First();

            Assert.AreEqual(name, reward.Name);
            Assert.AreEqual(description, reward.Description);
        }

        [TestMethod]
        public async Task GetRewardDetails_WithIncorrectDetails_ShouldThrowException()
        {
            await Assert.ThrowsExceptionAsync<InvalidOperationException>(
                () => this.service.GetRewardDetails(3));
        }

        private void CreateInitialRewards()
        {
            DanceType dance = (new DanceType()
            {
                Name = "Folklor"
            });

            this.context.Events.Add(new Event()
            {
                Id = 1,
                Name = "Gergiovden",
                Place = "Stefanovo",
                Address = "Stefanovo",
                Dance = dance,
                PosterUrl = "https://imageshack.com/a/img924/5145/O5s8hO.jpg",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(2)
            });

            this.context.Rewards.Add(new Reward()
            {
                Id = 1,
                Name = "First Place",
                Description = "Best Performance",
                EventId = 1,
                ImageUrl = "https://imageshack.com/a/img924/5145/O5s8hO.jpg"
            });

            this.context.Rewards.Add(new Reward()
            {
                Id = 2,
                Name = "Second Place",
                Description = "Second Best Performance",
                EventId = 1,
                ImageUrl = "https://imageshack.com/a/img924/5145/O5s8hO.jpg"
            });

            this.context.SaveChanges();
        }
    }
}
