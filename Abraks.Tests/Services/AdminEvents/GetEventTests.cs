namespace Abraks.Tests.Services
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Abraks.Services.Admin;
    using AutoMapper;
    using Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using Models;

    [TestClass]
    public class GetEventTests
    {
        private AbraksContext context;
        private AdminEventsService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.context = MockDbContext.GetContext();

            this.service = new AdminEventsService(this.context, MockAutoMapper.GetMapper());
        }

        [TestMethod]
        public async Task GetEvent_WithEvents_ShouldReturnAllCorrectly()
        {
            CreateInitialEvents();

            this.context.SaveChanges();

            var events = await service.GetEvents();

            Assert.IsNotNull(events);
            CollectionAssert.AreEqual(new[] { 1, 2 }, events.Select(e => e.Id).ToArray());
        }

        [TestMethod]
        public async Task GetEvent_WithEvents_ShouldReturnAll()
        {
            CreateInitialEvents();

            var events = await service.GetEvents();

            Assert.IsNotNull(events);
            Assert.AreEqual(2, events.Count());
        }

        [TestMethod]
        public async Task GetEvent_WithEvent_ShouldReturnCorretly()
        {
            const string name = "Trakia";

            CreateInitialEvents();

            var events = await service.GetEvents();

            var trakiaEvent = events.FirstOrDefault(e => e.Name == "Trakia");

            Assert.IsNotNull(events);

            Assert.AreEqual(name, trakiaEvent.Name);
        }

        [TestMethod]
        public async Task GetEvent_WithoutEvents_ShouldReturnAll()
        {
            var events = await service.GetEvents();

            Assert.IsNotNull(events);
            Assert.AreEqual(0, events.Count());
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
