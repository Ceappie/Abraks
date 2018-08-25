namespace Abraks.Services.Dancer.Interface
{
    using System.Threading.Tasks;
    using Common.Admin.BindingModels.Comments;

    public interface IDancerCommentsService
    {
        Task CreateComment(CommentCreatingBindingModel model);
    }
}
