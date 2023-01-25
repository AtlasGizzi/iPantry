using iPantry.Models;
using iPantry.Services;
using Microsoft.AspNetCore.Mvc;



namespace iPantry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase //controllerBase specifies that we are using HTTP responses?
    {
        private readonly AccountService _accountService; // this creates a class property that is private and read only
        public AccountController(IAccountService accountService) // when the controller is called it creates an instance of the account service. 
        {
            _accountService = (AccountService?)accountService; // each instance of the account service is equivient to the account service
        }

        [HttpPost]
        public async Task<ActionResult> Register(Account account) 
        { 
            await _accountService.Register(account);
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<List<Account>>> GetAll()
        {
            var accounts = await _accountService.GetAll();
            return Ok(accounts);
        }
    }
}
