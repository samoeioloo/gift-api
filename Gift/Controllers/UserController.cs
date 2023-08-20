using AutoMapper;
using Gift.Models;
using Gift.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Gift.Controllers
{
    /**[Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        
        public IUserService _heroService; 
        public UserController(IUserService heroService, IMapper mapper)
        {
            _heroService = heroService;
            _mapper = mapper;
        }
        
         [HttpGet]
         public async Task<ActionResult<List<User>>> GetAllHeroes()
         {
             var result = await _heroService.GetAllHeroes();
             return Ok(result.Select(s => _mapper.Map<HeroDto>(s)));
         }

         [HttpGet]
         [Route("{id}")]
         public async Task<ActionResult<List<User>>> GetAHero(int id)
         {
             return Ok(_heroService.GetAHero(id));
         }

         [HttpPost]
         public async Task<ActionResult<List<User>>> AddHero([FromBody]User h)
         {
             
             return Ok(_heroService.AddHero(h));
         }
         [HttpDelete]
         [Route("{id}")]
         public async Task<ActionResult<List<User>>> RemoveHero(int id)
         {
             
             return Ok(_heroService.RemoveHero(id));
         }

         [HttpPatch]
         [Route("{id}")]
         public async Task<ActionResult<User>> UpdateHero(int id, User request)
         {
             return Ok(_heroService.UpdateHero(request));
         }
         
    }*/
}

