using Microsoft.AspNetCore.Mvc;

namespace ABCBank.API.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
