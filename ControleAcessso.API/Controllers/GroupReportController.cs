using ControleAcessso.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcessso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupReportController : ControllerBase
    {
        private readonly IGroupReportService _grupoRelatorioService;
        public GroupReportController(IGroupReportService grupoRelatorioService)
        {
            _grupoRelatorioService = grupoRelatorioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var grupoRelatorio = _grupoRelatorioService.GetAll();

            return Ok(grupoRelatorio);
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
