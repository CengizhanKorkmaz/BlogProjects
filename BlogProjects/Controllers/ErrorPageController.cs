using Microsoft.AspNetCore.Mvc;

namespace BlogProjects.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult ErrorOne(int code)
        {
            return View();
        }
    }
}
