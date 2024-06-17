using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITSM.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Cadastrar()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Atualizar()
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Excluir(Guid id)
        {
            return Ok();
        }
        [HttpGet("{page}/{limit}")]
        public IActionResult BuscarTodos(int page, int limit)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            return Ok();
        }
    }
}
