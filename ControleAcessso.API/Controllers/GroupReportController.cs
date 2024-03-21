using ControleAcesso.Application.InputModels;
using ControleAcessso.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcessso.API.Controllers
{
    [Route("api/groupsReports")]
    [ApiController]
    public class GroupReportController : ControllerBase
    {
        private readonly IGroupReportService _groupReportService;
        public GroupReportController(IGroupReportService groupReportService)
        {
            _groupReportService = groupReportService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var grupoRelatorio = _groupReportService.GetAll();

            return Ok(grupoRelatorio);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var group = _groupReportService.GetById(id);

            return Ok(group);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewGroupReportInputModel inputModel)
        {
            var id = _groupReportService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id}, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateGroupReportInputModel inputModel)
        {
            _groupReportService.Update(inputModel);

            return NoContent();
        }
    }
}
