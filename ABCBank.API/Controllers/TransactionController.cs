using Microsoft.AspNetCore.Mvc;

namespace ABCBank.API.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
