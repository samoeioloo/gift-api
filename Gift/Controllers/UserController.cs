using AutoMapper;
using Gift.Models;
using Gift.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Gift.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]/")]
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
        
         [HttpGet]
         [Route("{userId}/eras")]
         [ProducesResponseType(StatusCodes.Status200OK)]
         [ProducesResponseType(StatusCodes.Status403Forbidden)]
         [ProducesResponseType(StatusCodes.Status404NotFound)]
         [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult<List<Era>>> GetErasForUser([FromBody] int userId)
         {
            var response = await _userService.GetErasForUser(userId);
            if(response != null)
                return Ok(response.Select(_mapper.Map<Era>));
            else
            {
                return NotFound("No eras found for this user. Create one.");
            }
         }

         /**[HttpGet]
         [Route("{id}")]
         public async Task<ActionResult<List<User>>> GetAHero(int id)
         {
             return Ok(_userService.GetAHero(id));
         }

         [HttpPost]
         public async Task<ActionResult<List<User>>> AddHero([FromBody]User h)
         {
             
             return Ok(_userService.AddHero(h));
         }
         [HttpDelete]
         [Route("{id}")]
         public async Task<ActionResult<List<User>>> RemoveHero(int id)
         {
             
             return Ok(_userService.RemoveHero(id));
         }

         [HttpPatch]
         [Route("{id}")]
         public async Task<ActionResult<User>> UpdateHero(int id, User request)
         {
             return Ok(_userService.UpdateHero(request));
         }*/
         
    }
}

