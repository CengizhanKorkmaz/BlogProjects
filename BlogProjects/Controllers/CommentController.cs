using System;
using BusinessLayer.Abstracts;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    public class CommentController : Controller
    {
        ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
      
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CreatedTime=DateTime.Now;
            comment.Status = true;
            _commentService.Add(comment);
            return PartialView();
        }

    }
}
