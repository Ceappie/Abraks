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
    public class GetRewardTests
    {
        private AbraksContext context;
        private AdminRewardsService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.context = MockDbContext.GetContext();

            this.service = new AdminRewardsService(this.context, MockAutoMapper.GetMapper());
        }

        [TestMethod]
        public async Task GetReward_WithRewards_ShouldReturnAllCorrectly()
        {
            CreateInitialRewards();

            this.context.SaveChanges();

            var rewards = await service.GetRewards();

            Assert.IsNotNull(rewards);
            CollectionAssert.AreEqual(new[] { 1, 2 }, rewards.Select(e => e.Id).ToArray());
        }

        [TestMethod]
        public async Task GetReward_WithRewards_ShouldReturnAll()
        {
            CreateInitialRewards();

            var rewards = await service.GetRewards();

            Assert.IsNotNull(rewards);
            Assert.AreEqual(2, rewards.Count());
        }

        [TestMethod]
        public async Task GetReward_WithReward_ShouldReturnCorretly()
        {
            const string name = "First Place";

            CreateInitialRewards();

            var rewards = await service.GetRewards();

            var firstPlace = rewards.FirstOrDefault(e => e.Name == "First Place");

            Assert.IsNotNull(rewards);

            Assert.AreEqual(name, firstPlace.Name);
        }

        [TestMethod]
        public async Task GetReward_WithoutRewards_ShouldReturnAll()
        {
            var rewards = await service.GetRewards();

            Assert.IsNotNull(rewards);
            Assert.AreEqual(0, rewards.Count());
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
