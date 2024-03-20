using ControleAcesso.Application.InputModels;
using ControleAcessso.API.InputModels;
using ControleAcessso.API.Services.Implementations;
using ControleAcessso.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcessso.API.Controllers
{
    [Route("api/relatorios")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _relatorioService;
        public ReportController(IReportService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var relatorios =_relatorioService.GetAll();
            return Ok(relatorios);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var userViewModel = _relatorioService.GetById(id);

            return Ok(userViewModel);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewReportInputModel inputModel)
        {
            var id = _relatorioService.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateReportInputModel inputModel)
        {
            _relatorioService.Update(inputModel);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _relatorioService.Delete(id);

            return NoContent();
        }
    }
}
