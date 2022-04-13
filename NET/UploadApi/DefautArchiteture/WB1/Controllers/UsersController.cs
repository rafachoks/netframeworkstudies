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
        private readonly IBaseService<User> _baseUserService;

        public UsersController(IBaseService<User> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        /// <summary>
        /// Create a new user within the application
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            if (user == null)
                return NotFound();

            return Execute(() => _baseUserService.Add<UserValidator>(user).Id);
        }

        /// <summary>
        /// Update user information
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] User user)
        {
            if (user == null)
                return NotFound();

            _baseUserService.Update<UserValidator>(user);

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
            if (id == 0)
                return NotFound();

            Execute(() =>
            {
                _baseUserService.Delete(id);
                return true;
            });

            return new NoContentResult();
        }

        /// <summary>
        /// Recover all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("user/getall")]
        public IActionResult GetAllUser()
        {
            return Execute(() => _baseUserService.GetAll());
        }

        /// <summary>
        /// Recover an specific user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => _baseUserService.Get(id));
        }

        /// <summary>
        /// Default parameter class
        /// </summary>
        /// <param name="func"></param>
        /// <returns></returns>
        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
