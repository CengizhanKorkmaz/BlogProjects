using System.Linq;
using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        private ICommentService _commentService;

        public CommentListByBlog(ICommentService commentService)
        {
            _commentService= commentService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _commentService.GetAll().Where(x => x.BlogId == ViewBag.Id).ToList();
            return View(result);
        }
    }
}
