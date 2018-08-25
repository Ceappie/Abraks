namespace Abraks.Web.Areas.Dancer.Controllers
{
    using System.Threading.Tasks;
    using Common.Admin.BindingModels.Comments;
    using Microsoft.AspNetCore.Mvc;
    using Services.Dancer.Interface;

    public class CommentsController : DancerController
    {
        private readonly IDancerCommentsService commentsService;

        public CommentsController(IDancerCommentsService commentsService)
        {
            this.commentsService = commentsService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CommentCreatingBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Details", "Events");
            }

            await this.commentsService.CreateComment(model);

            return RedirectToAction("Details", "Events");
        }
    }
}
