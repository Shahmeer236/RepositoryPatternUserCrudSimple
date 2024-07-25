using AutoMapper;
using CrudRepo.Dtos.User;
using CrudRepo.Enities;
using CrudRepo.Services.Implementation;
using CrudRepo.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CrudRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices, IMapper mapper)
        {
            _userServices = userServices;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserforListing>>> GetUsers()
        {
            var users = await _userServices.GetUsersAsync();
            var userDtos = _mapper.Map<List<UserforListing>>(users);
            return Ok(userDtos);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUserById(int id)
        {
            var user = await _userServices.GetUserByIdAsync(id);
            return Ok(user);
        }


       

        [HttpDelete("{id}")]

        public async Task<ActionResult> DeleteUser(int id)
        {
            var result=await _userServices.DeleteUsersAsync(id);
            if(!result)
            {
                return NotFound(id);
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<UserForCreation>> AddUser(UserForCreation userForCreation)
        {
            var userId = await _userServices.AddUserAsync(userForCreation);

            return CreatedAtAction(nameof(GetUserById), new {id=userId},userId);
        }

        [HttpPut]
        public async Task<ActionResult> updateUser (UserForUpdation userForUpdation)
        {
            var result=await _userServices.UpdateUserAsync(userForUpdation);
            if(! result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
