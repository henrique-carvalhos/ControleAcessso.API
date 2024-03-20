using ControleAcessso.API.InputModels;
using ControleAcessso.API.Persistence;
using ControleAcessso.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcessso.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var user = _userService.GetAll();

            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            var userViewModel = _userService.GetAllViewModel(id);

            return Ok(userViewModel);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewUserInputModel inputModel)
        {
            var id = _userService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id}, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateUserInputModel inputModel)
        {
            _userService.Update(inputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);

            return NoContent();
        }
    }
}
