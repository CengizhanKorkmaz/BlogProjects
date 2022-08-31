using System.Linq;
using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.ViewComponents.Blog
{
    public class BlogLastThreePost:ViewComponent
    {
        private IBlogService _blogService;

        public BlogLastThreePost(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var blogs = _blogService.GetAll().OrderByDescending(x => x.CreatedTime).Take(3).ToList();
            return View(blogs);
        }
    }
}
