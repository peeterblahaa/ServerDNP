using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;

using ServerDNP.Permistence;

namespace ServerDNP.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService) => this.userService = userService;

        [HttpGet]
        public async Task<ActionResult<IList<User>>> GetUsers()
        {
            try
            {
                IList<User> users = await userService.GetUsers();
                return Ok(users);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser([FromBody] User user)
        {
            try
            {
                userService.ValidateUser(user.Username, user.Password);
                User added = await userService.Add(user);
                return Created($"/{added.Username}", added);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}