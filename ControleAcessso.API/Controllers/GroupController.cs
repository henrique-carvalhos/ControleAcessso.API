using ControleAcesso.Application.InputModels;
using ControleAcessso.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcessso.API.Controllers
{
    [Route("api/groups")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private IGroupService _groupService;
        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;        
        }

        [HttpGet]
        public IActionResult Get()
        {
            var groups = _groupService.GetAll();
            return Ok(groups);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var groups = _groupService.GetById(id);
            return Ok(groups);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewGroupInputModel inputModel)
        {
            var id = _groupService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateGroupInputModel inputModel)
        {
            _groupService.Update(inputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _groupService.Delete(id);

            return NoContent();
        }
    }
}
