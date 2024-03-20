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

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
