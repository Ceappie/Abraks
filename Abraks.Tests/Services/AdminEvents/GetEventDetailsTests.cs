namespace Abraks.Tests.Services.AdminEvents
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Abraks.Services.Admin;
    using Common.Admin.BindingModels.Events;
    using Common.Admin.ViewModels.Events;
    using Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;
    using Models;

    [TestClass]
    public class GetEventDetailsTests
    {
        private AbraksContext context;
        private AdminEventsService service;

        [TestInitialize]
        public void InitializeTests()
        {
            this.context = MockDbContext.GetContext();
            this.service = new AdminEventsService(context, MockAutoMapper.GetMapper());
        }
        
        [TestMethod]
        public async Task GetEventDetails_WithCorrectDetails_ShouldWorkProperly()
        {
            const string name = "Gergiovden";
            const string place = "Stefanovo";
            const string address = "Stefanovo";

            CreateInitialEvents();

            await this.service.GetEventDetails(1);
            var @event = this.context.Events.First();

            Assert.AreEqual(name, @event.Name);
            Assert.AreEqual(place, @event.Place);
            Assert.AreEqual(address, @event.Address);
        }

        [TestMethod]
        public async Task GetEventDetails_WithIncorrectDetails_ShouldThrowException()
        {
            await Assert.ThrowsExceptionAsync<ArgumentNullException>(
                () => this.service.GetEventDetails(3));
        }

        private void CreateInitialEvents()
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

            this.context.Events.Add(new Event()
            {
                Id = 2,
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
