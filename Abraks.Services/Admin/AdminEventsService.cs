namespace Abraks.Services.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Abraks.Models;
    using AutoMapper;
    using Common.Admin.BindingModels.Events;
    using Common.Admin.ViewModels.Events;
    using Data;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class AdminEventsService : BaseAbraksService, IAdminEventsService
    {
        public AdminEventsService(AbraksContext dbContext, IMapper mapper)
            : base(dbContext, mapper) { }

        public async Task<int> AddEvent(EventAddingBindingModel model)
        {
            DanceType dance = DbContext
                .DanceTypes
                .FirstOrDefault(dt => dt.Name == model.Dance);

            if (model.Address == null)
            {
                model.Address = model.Place;
            }
            
            Event @event = new Event()
            {
                Name = model.Name,
                Dance = dance,
                Place = model.Place,
                Address = model.Address,
                PosterUrl = model.PosterUrl,
                StartDate = model.StartDate,
                EndDate = model.EndDate
            };           

            await this.DbContext.Events.AddAsync(@event);
            await this.DbContext.SaveChangesAsync();

            return @event.Id;
        }

        public async Task<IEnumerable<EventsViewModel>> GetEvents()
        {
            List<Event> events = await this.DbContext.Events.ToListAsync();
            IEnumerable<EventsViewModel> modelEvents = this.Mapper.Map<IEnumerable<EventsViewModel>>(events);
            return modelEvents;
        }

        public async Task<EventDetailsViewModel> GetEventDetails(int id)
        {
            var @event = await this.DbContext.Events
                .Include(e => e.Dance)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (@event == null)
            {
                throw new ArgumentNullException();
            }

            string dance = @event.Dance.Name;

            var model = new EventDetailsViewModel()
            {
                Name = @event.Name,
                Dance = dance,
                Place = @event.Place,
                Address = @event.Address,
                PosterUrl = @event.PosterUrl,
                StartDate = @event.StartDate,
                EndDate = @event.EndDate
            };

            return model;
        }
    }
}
