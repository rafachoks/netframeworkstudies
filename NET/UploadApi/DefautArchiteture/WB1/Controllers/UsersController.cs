using Blinks.Project.Application.Model;
using Blinks.Project.Domain;
using Blinks.Project.Service;
using Blinks.Project.Service.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WB1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// Create a new user within the application
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        public IActionResult Create([FromBody] UserModel user)
        {
            return Ok();
        }

        /// <summary>
        /// Update user information
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] User user)
        {
            return Ok();
        }

        /// <summary>
        /// Dete user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        /// <summary>
        /// Recover all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("user/getall")]
        public IActionResult GetAllUser()
        {
            return Ok();
        }

        /// <summary>
        /// Recover an specific user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }
    }
}
