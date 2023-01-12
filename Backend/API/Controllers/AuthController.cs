using BusinessLogic.Dto.AuthDto;
using BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegisterDto>> Register([FromBody] RegisterDto user)
        {
            var createdUser = await authService.Register(user);

            if (!createdUser)
            {
                return BadRequest("Your date not valide");
            }

            return Ok("Congratulations, you are successfully registered on.");
        }
    }
}
