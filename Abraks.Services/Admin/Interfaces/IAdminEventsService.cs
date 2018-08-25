namespace Abraks.Services.Admin.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Common.Admin.BindingModels.Events;
    using Common.Admin.ViewModels.Events;

    public interface IAdminEventsService
    {
        Task<IEnumerable<EventsViewModel>> GetEvents();

        Task<int> AddEvent(EventAddingBindingModel model);

        Task<EventDetailsViewModel> GetEventDetails(int id);
    }
}
