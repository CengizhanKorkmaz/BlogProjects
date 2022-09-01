using System;
using BusinessLayer.Abstracts;
using BusinessLayer.FluenValidationRules;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    public class AuthController : Controller
    {
        private IWriterService _writerService;

        public AuthController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Writer writer)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Writer writer)
        {
            WriterValidator validator = new WriterValidator();
            var result = validator.Validate(writer);
            if (result.IsValid)
            {
                _writerService.Add(writer);
                return RedirectToAction("Login","Auth");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}
