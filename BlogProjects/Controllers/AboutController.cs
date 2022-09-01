using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    public class AboutController : Controller
    {
        private IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        public IActionResult Index()
        {
            var result = _aboutService.GetById( 1);
            return View(result);
        }
    }
}
