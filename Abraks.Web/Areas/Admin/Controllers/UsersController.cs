namespace Abraks.Web.Areas.Admin.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Abraks.Data;
    using Abraks.Models;
    using AutoMapper;
    using Common.Admin.ViewModels.Users;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class UsersController : DancerController
    {
        private readonly AbraksContext context;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;

        public UsersController(AbraksContext context, IMapper mapper, UserManager<User> userManager)
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            User currentUser = await this.userManager.GetUserAsync(this.User);
            List<User> users = this.context
                .Users
                .Where(u => u.Id != currentUser.Id)
                .ToList();

            IEnumerable<UsersViewModel> model = this.mapper.Map<IEnumerable<UsersViewModel>>(users);

            return View(model);
        }

        public async Task<IActionResult> Details(string id)
        {
            var currentUser = await this.userManager.GetUserAsync(this.User);
            if (id == currentUser.Id)
            {
                return Unauthorized();
            }

            var user = await this.context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var roles = await this.userManager.GetRolesAsync(user);
            var model = this.mapper.Map<UserDetailsViewModel>(user);

            return View(model);
        }

        //TO DO Ban Action
    }
}
