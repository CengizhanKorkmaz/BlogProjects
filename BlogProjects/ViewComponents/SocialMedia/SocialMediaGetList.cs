using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.ViewComponents.SocialMedia
{
    public class SocialMediaGetList:ViewComponent
    {
        private ISocialMediaService _socialMediaService;

        public SocialMediaGetList(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _socialMediaService.GetAll();
            return View(result);
        }
    }
}
