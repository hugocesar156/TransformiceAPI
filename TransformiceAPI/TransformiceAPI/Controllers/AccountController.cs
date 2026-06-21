using Microsoft.AspNetCore.Mvc;
using TransformiceAPI.Application.Interfaces;

namespace TransformiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var response = await _accountService.Get();
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
