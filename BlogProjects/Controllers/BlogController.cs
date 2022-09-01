﻿using System.Linq;
using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    public class BlogController : Controller
    {
        private IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
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
       
    }
}
