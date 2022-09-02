using System;
using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    public class ContactController : Controller
    {
        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult ContactAdd()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {
            contact.CreatedTime=DateTime.Now;
            contact.Status = true;
            _contactService.Add(contact);
            return PartialView();
        }
    }
}
