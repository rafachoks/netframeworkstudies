using Blinks.Project.Domain.User;
using Blinks.Project.Service;
using Blinks.Project.Service.Validators;
using FluentAssertions.Execution;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IBaseService<User> _baseUserService;

        public UserController(IBaseService<User> baseUserService)
        {
            _baseUserService = baseUserService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (user == null)
                return NotFound();

            return Execute(() => _baseUserService.Add<UserValidator>(user).Id);
        }

        [HttpGet]
        public IActionResult GetUser(int id)
        {
            return Execute(() => _baseUserService.Get(id));
        }

        private IActionResult Execute(Func<int> func)
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
