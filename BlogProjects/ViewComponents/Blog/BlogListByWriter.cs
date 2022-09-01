using System.Linq;
using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.ViewComponents.Blog
{
    public class BlogListByWriter:ViewComponent
    {
        private IBlogService _blogService;

        public BlogListByWriter(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _blogService.GetListWithCategoryAndWriter().Where(x => x.WriterId == id)
                .OrderByDescending(x => x.CreatedTime).Take(3).ToList();
            return View(result);

        }
    }
}
