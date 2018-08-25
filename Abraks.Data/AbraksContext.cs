namespace Abraks.Data
{
    using Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class AbraksContext : IdentityDbContext<User>
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Reward> Rewards { get; set; }

        public DbSet<DanceType> DanceTypes { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public AbraksContext(DbContextOptions<AbraksContext> options)
            : base(options) { }
    }
}
