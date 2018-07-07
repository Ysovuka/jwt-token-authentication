using Microsoft.AspNetCore.Mvc;

namespace Application.Areas.Admin.Controllers.Web
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
