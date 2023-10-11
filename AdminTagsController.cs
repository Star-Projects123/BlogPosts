using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
