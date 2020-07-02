using System.Threading.Tasks;
using AutoMapper;
using IEIMobile.Models;
using IEIMobile.Models.Dtos;
using IEIMobile.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace IEIMobile.Controllers {

    // [EnableCors("AllowOrigin")] 
    public class UsersController : ControllerBase {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;
        public UsersController (IUserRepo userRepo, IMapper mapper) {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        [HttpPost ("api/Users/Login")]
        public async Task<IActionResult> Login ([FromBody] UserDto userDto) {
            
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            User user = _mapper.Map<User> (userDto);
            if(!_userRepo.Authenticate(user)){
                AuthDataDto authData = new AuthDataDto{
                    Pin = user.Pin,
                    Status = "Failed",
                    Message = "The login details supplied is incorrect",
                    Token = "",
                    ExpirationTime = 0
                };
                return BadRequest(authData);
            }
            else {
                AuthDataDto authData = await _userRepo.SignUserIn(user);
                return Ok(authData);
            }
        }



        // [HttpGet("api/Users")]
        // public IActionResult GetVehicles(){
        //     var vehicles =  _context.Vehicles.FromSqlRaw("[dbo].[SelectAllVehicles]");
        //     return Ok(vehicles);
        // }
    }
}