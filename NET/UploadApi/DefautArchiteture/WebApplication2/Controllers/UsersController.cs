using Blinks.Project.Domain;
using Blinks.Project.Service;
using Blinks.Project.Service.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBaseService<User> _baseService;

        public UsersController(IBaseService<User> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        [Route("/getall")]
        public IActionResult GetAll()
        {
            return Ok(_baseService.GetAll());
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_baseService.Get(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            if (user == null)
                return BadRequest();
            return Execute(() => _baseService.Add<UserValidator>(user));
        }

        [HttpPut]
        public IActionResult Update([FromBody] User user)
        {
            if (user == null)
                return BadRequest();
            return Execute(() => _baseService.Add<UserValidator>(user));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            return Ok(() => _baseService.Delete(id));
        }

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
