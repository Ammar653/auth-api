using AuthApi.Helpers;
using AuthApi.Models;
using AuthApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin request)
        {
            var user = UserRepository.ValidateUser(request.Username, request.Password);
            if (user == null)
            {
                return Unauthorized();
            }

            var token = JwtTokenGenerator.GenerateToken(user);
            return Ok(new { Token = token });
        }
    }
}