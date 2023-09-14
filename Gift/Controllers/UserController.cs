using AutoMapper;
using Gift.Models;
using Gift.Models.Requests;
using Gift.Services.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gift.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/users")]
    [ApiVersion("1.0")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        
        public IUserService _userService;
        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
		[HttpPost]
        [Route("/signup")]
        public async Task<ActionResult<Guid>> AddUser([FromBody] UserSignupRequest user)
		{

			return Ok( await _userService.AddUser(user));
		}

        [AllowAnonymous]
        [HttpPost]
        [Route("/authenticate")]
        public async Task<IActionResult> Authenticate(AuthenticateRequest request)
        {
            var response = await _userService.AuthenticateUser(request);
            if (response is null)
                return Unauthorized();
            return Ok(response);
        }
        /**
		[HttpGet]
		[Route("")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status403Forbidden)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<User>> GetCurrentUser([FromQuery] int? userId)
        {
            var response = await _userService.GetCurrentUser(userId);
            if(response != null)
            {
                return Ok(response);
            }
            else
            {
                return NotFound("This user is not found.");
            }
        }*/

		[HttpGet]
        [Route("{userId}/eras")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<List<Era>>> GetErasForUser(int? userId)
        {
            if (userId != null)
            {
                var response = await _userService.GetErasForUser(userId);
                if (response != null)
                    return Ok(response.Select(_mapper.Map<Era>));
                else
                {
                    return NotFound("No eras found for this user. Create one.");
                }
            }

            return BadRequest("No user provided.");
        }

    }
}

