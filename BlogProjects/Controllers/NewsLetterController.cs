using System;
using BusinessLayer.Abstracts;
using BusinessLayer.Concretes;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    public class NewsLetterController : Controller
    {
        private INewsLetterService _letterService;

        public NewsLetterController(INewsLetterService letterService)
        {
            _letterService = letterService;
        }

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.Status = true;
            newsLetter.CreatedTime=DateTime.Now;
            _letterService.Add(newsLetter);
            return PartialView();
        }
        [HttpGet]
        public IActionResult FooterSubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult FooterSubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.Status = true;
            newsLetter.CreatedTime = DateTime.Now;
            _letterService.Add(newsLetter);
            return PartialView();
        }
    }
}
