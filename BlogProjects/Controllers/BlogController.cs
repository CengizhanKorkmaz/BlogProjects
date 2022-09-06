using System.Linq;
using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        private IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            var result = _blogService.GetListWithCategoryAndWriter();

            return View(result);
        }
        [HttpGet]
        public IActionResult BlogDetails(int id)
        {
            var result = _blogService.GetListWithCategoryAndWriterById(id);
            ViewBag.Id = id;
            ViewBag.Flap = 1;
            ViewBag.WriterId = result.WriterId;
            return View(result);
        }

        public IActionResult BlogListByCategoryId(int id)
        {
            var result= _blogService.GetListByCategoryId(id);
            return View(result);
        }

    }
}
