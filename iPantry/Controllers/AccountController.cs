using iPantry.Models;
using iPantry.Services;
using Microsoft.AspNetCore.Mvc;



namespace iPantry.Controllers
{
    //[Route("api/Account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountService _accountService;
        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<ActionResult> Register(Account account) 
        { 
            await _accountService.Register(account);
            return Ok();
        }
    }
}
