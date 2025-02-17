
using proyectoBackendAmadeusNet.services.interfaces;
using proyectoBackendAmadeusNet.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using proyectoBackendAmadeusNet.services;
using proyectoBackendAmadeusNet.models;

namespace proyectoBackendAmadeusNet.controllers{


    [ApiController]
    [Route("api/[controller]")]    
    public class UserController: ControllerBase{

        private readonly IUserService _userService;

         public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUsersAll()
        {
            var listUsers= await _userService.GetUserListAsync();
            return Ok(listUsers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUserById(int id)
        {
            var userById = await _userService.GetUserByIdAsync(id);
            return Ok(userById);
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> CreateUser (UserModel userModel)
        {
            var userCreated = await _userService.CreateUserAsync(userModel);
            return Ok(userCreated);
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserModel>> Login([FromBody] LoginDTO loginDto)
        {
            var user = await _userService.AuthenticateUserAsync(loginDto.Correo, loginDto.Contrasena);
            if (user == null)
            {
                return Unauthorized();
            }
            return Ok(user);
        }
    }

}


