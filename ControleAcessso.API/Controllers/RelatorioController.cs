using ControleAcessso.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleAcessso.API.Controllers
{
    [Route("api/relatorios")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly IRelatorioService _relatorioService;
        public RelatorioController(IRelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var relatorios =_relatorioService.GetAll();
            return Ok(relatorios);
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
