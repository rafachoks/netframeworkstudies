using Blinks.Project.Domain;
using Blinks.Project.Service;
using Blinks.Project.Service.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IBaseService<User> _baseService;

        public UsersController(IBaseService<User> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public IActionResult Get([FromHeader]int id) 
        {
            if (id == 0)
                return NotFound();

            return Ok(() => _baseService.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(() => _baseService.GetAll());
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user) 
        {
            if (user == null)
                return NotFound();

            return Execute(() => _baseService.Add<UserValidator>(user));
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
