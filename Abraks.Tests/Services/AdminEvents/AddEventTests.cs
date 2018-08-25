namespace Abraks.Tests.Services.AdminEvents
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Abraks.Services.Admin;
    using Common.Admin.BindingModels.Events;
    using Data;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Mocks;

    [TestClass]
    public class AddEventTests
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
        public async Task AddEvent_WithCorrectEvent_ShouldWorkProperly()
        {
            const string name = "Event Testing Name";
            const string place = "Event Testing Place";
            const string address = "Event Testing Address";

            var eventModel = new EventAddingBindingModel()
            {
                Name = "Event Testing Name",
                Place = "Event Testing Place",
                Address = "Event Testing Address",
                Dance = "Folklor",
                PosterUrl = "https://dveri.bg/cache/new5/6/1687d8c0fb11c8f4e2a1d603e65e6e1a.png",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(2)
            };

            await this.service.AddEvent(eventModel);
            var @event = this.context.Events.First();

            Assert.AreEqual(name, @event.Name);
            Assert.AreEqual(place, @event.Place);
            Assert.AreEqual(address, @event.Address);
        }

        [TestMethod]
        public async Task AddEvent_WithCorrectFewEvent_ShouldAddProperly()
        {
            var firstEventModel = new EventAddingBindingModel()
            {
                Name = "First Event Testing Name",
                Place = "First Event Testing Place",
                Address = "First Event Testing Address",
                Dance = "Folklor",
                PosterUrl = "https://dveri.bg/cache/new5/6/1687d8c0fb11c8f4e2a1d603e65e6e1a.png",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(2)
            };

            var secondEventModel = new EventAddingBindingModel()
            {
                Name = "Second Event Testing Name",
                Place = "Second Event Testing Place",
                Address = "Second Event Testing Address",
                Dance = "Folklor",
                PosterUrl = "https://dveri.bg/cache/new5/6/1687d8c0fb11c8f4e2a1d603e65e6e1a.png",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(2)
            };

            await this.service.AddEvent(firstEventModel);
            await this.service.AddEvent(secondEventModel);

            Assert.AreEqual(2, this.context.Events.Count());
        }

        [TestMethod]
        public async Task AddEvent_WithNullEvent_ShouldThrowException()
        {
            EventAddingBindingModel eventModel = null;

            await Assert.ThrowsExceptionAsync<InvalidOperationException>(
                () => this.service.AddEvent(eventModel));
        }
    }
}
