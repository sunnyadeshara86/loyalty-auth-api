using Loyalty.Auth.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loyalty.Auth.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
        #region Private Members

        private readonly ILogger<AuthController> _logger;

		#endregion

		#region Constructors

		public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

		#endregion

		#region Get Methods

		[HttpGet]
		[Route("revokeToken")]
		[ProducesResponseType(204)]
		[ProducesResponseType(403, Type = typeof(ErrorResponse))]
		public IActionResult RevokeToken()
		{
			return NoContent();
		}

		#endregion

		#region Post Methods

		[HttpPost]
        [Route("login")]
        [ProducesResponseType(200, Type = typeof(LoginResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		public IActionResult Login(LoginRequest loginRequest)
        {
            return Ok(new LoginResponse());
        }

		[HttpPost]
		[Route("{tenantId}/member/login")]
		[ProducesResponseType(200, Type = typeof(LoginResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		public IActionResult LoginForMember([FromRoute]string tenantId, LoginRequest loginRequest)
		{
			return Ok(new LoginResponse());
		}

		[HttpPost]
		[Route("refreshToken")]
		[ProducesResponseType(200, Type = typeof(LoginResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		public IActionResult RefreshToken(RefreshTokenRequest refreshTokenRequest)
		{
			return Ok(new LoginResponse());
		}

		[HttpPost]
		[Route("{tenantId}/refreshToken")]
		[ProducesResponseType(200, Type = typeof(LoginResponse))]
		[ProducesResponseType(401, Type = typeof(ErrorResponse))]
		public IActionResult RefreshMemberToken([FromRoute] string tenantId, RefreshTokenRequest refreshTokenRequest)
		{
			return Ok(new LoginResponse());
		}

		#endregion
	}
}
