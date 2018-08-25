namespace Abraks.Services.Dancer
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
    using Common.Admin.BindingModels.Comments;
    using Data;
    using Interface;
    using Models;

    public class DancerCommentsService : BaseAbraksService, IDancerCommentsService
    {
        public DancerCommentsService(AbraksContext dbContext, IMapper mapper)
            : base(dbContext, mapper) { }

        public async Task CreateComment(CommentCreatingBindingModel model)
        {
            //TODO Get EventId

            Comment comment = new Comment()
            {
                Content = model.Content,
                PublishDate = DateTime.Now
            };
            await this.DbContext.Comments.AddAsync(comment);
            await this.DbContext.SaveChangesAsync();
        }

        
    }
}
