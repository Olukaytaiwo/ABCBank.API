using ABCBank.Core;
using ABCBank.Data;
using Microsoft.AspNetCore.Mvc;

namespace ABCBank.API.Controllers
{
    [Route("api/v1.0/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private IAccountService _accountService;
        public AccountController(
            IAccountService accountService
            )
        {
            _accountService = accountService;
        }

        [HttpPost]
        [Route("RegisterUser")]
        public async Task<IActionResult> RegisterUser(RegistrationRequest registration )
        {
            var response = await _accountService.RegisterUser(registration);
            return Ok(response);
        }

        [HttpGet]
        [Route("FetchAllUsers")]
        public async Task<IActionResult> FetchAllUsers()
        {
            var response = await _accountService.FetchAllUsers();
            return Ok(response);
        }



    }
}
