using System;
using System.Collections.Generic;
using System.Security.Claims;
using BusinessLayer.Abstracts;
using BusinessLayer.FluenValidationRules;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private IWriterService _writerService;
        private ILoginService _loginService;

        public AuthController(IWriterService writerService,ILoginService loginService)
        {
            _writerService = writerService;
            _loginService = loginService;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            var result = _loginService.Login(email, password);
            if (result!=null)
            {
                var claims = new List<Claim>{
                    new Claim(ClaimTypes.Name, email),
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Blog");
            }
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
