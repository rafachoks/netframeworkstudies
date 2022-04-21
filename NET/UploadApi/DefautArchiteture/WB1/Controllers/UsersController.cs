using Blinks.Project.Application.Interface;
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

        public readonly IUserBusiness _userBusiness;

        public UsersController(IUserBusiness userBusiness)
        {
            this._userBusiness = userBusiness;
        }

        /// <summary>
        /// Create a new user within the application
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        public IActionResult Create([FromBody] UserModel user)
        {
            _userBusiness.CreateUser(user);

            return Ok();
        }

        /// <summary>
        /// Update user information
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] UserModel user)
        {
            _userBusiness.UpdateUser(user);

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
            _userBusiness.DeleteUser(id);

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
            return Ok(_userBusiness.GetAllUsers());
        }

        /// <summary>
        /// Recover an specific user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_userBusiness.GetUser(id));
        }
    }
}
