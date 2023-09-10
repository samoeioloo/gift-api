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

         public async Task<ActionResult<List<Era>>> GetErasForUser(int userId)
         {
             var result = await _userService.GetErasForUser(userId);
             return Ok(result.Select(s => _mapper.Map<Era>(s)));
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

