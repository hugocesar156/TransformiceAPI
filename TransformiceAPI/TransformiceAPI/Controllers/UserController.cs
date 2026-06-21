using Microsoft.AspNetCore.Mvc;
using System.Net;
using TransformiceAPI.Application.Interfaces;
using TransformiceAPI.Application.Models.Requests;
using TransformiceAPI.Application.Models.Responses;

namespace TransformiceAPI.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        [ProducesResponseType(typeof(AuthenticationResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> Login(AuthenticationRequest request)
        {
            try
            {
                var response = await _userService.Authenticate(request);
                return StatusCode((int)HttpStatusCode.OK, response);
            }
            catch (HttpRequestException ex)
            {
                return StatusCode(ex.StatusCode.HasValue ? (int)ex.StatusCode : (int)HttpStatusCode.BadRequest, new { ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, new { ex.Message });
            }
        }
    }
}
