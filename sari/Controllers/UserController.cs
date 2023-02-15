using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Milgot.API.Models;
using Milgot.Common.DTOs;
using Milgot.Services.Interface;
using Milgot.Services.Services;

namespace Milgot.API.Controllers
{
    //[Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("ReactPolicy")]

    public class UserController : ControllerBase
    {
        readonly IUserService _details;

        public UserController(IUserService details)
        {
            _details = details;
        }

        [HttpGet]
        public async Task<List<UserDTO>> GetAllAsync()
        {
            return await _details.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDTO> GetAsync(int id)
        {
            return await _details.GetByIdAsync(id);
        }


        [HttpPost]
        public async Task<UserDTO> AddAsync([FromBody] UserModel user)
        {
            return await _details.AddAsync(new UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Tz = user.Tz,
                DateOfBirth = user.DateOfBirth,
                Gender = user.Gender,
                HMO = user.HMO
            });
            
        }

        [HttpPut]
        public async Task<UserDTO> UpdateAsync([FromBody] UserModel user)
        {
            return await _details.UpdateAsync(new UserDTO
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Tz = user.Tz,
                DateOfBirth = user.DateOfBirth,
                Gender = user.Gender,
                HMO = user.HMO
            });
        }

        [HttpDelete]
        public async Task DeleteAsync(int id)
        {
            await _details.DeleteAsync(id);
        }
    }
}
