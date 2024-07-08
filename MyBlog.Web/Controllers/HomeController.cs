using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FakeAction()
        {
            throw new NotImplementedException();
        }
    }

}
