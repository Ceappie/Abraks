namespace Abraks.Services
{
    using AutoMapper;
    using Data;

    public abstract class BaseAbraksService
    {
        protected BaseAbraksService(AbraksContext dbContext, IMapper mapper)
        {
            this.DbContext = dbContext;
            this.Mapper = mapper;
        }

        protected AbraksContext DbContext { get; set; }

        protected IMapper Mapper { get; set; }
    }
}
