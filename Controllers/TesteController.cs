using Microsoft.AspNetCore.Mvc;

namespace InjecaoDeDependencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly IOperacao _operacao;

        public TesteController(IOperacao operacao)
        {
            _operacao = operacao;
        }    
        
        [HttpGet("FromConstructor")]
        public IActionResult GetFromConstructor()
        {
            return Ok(_operacao.Id);
        }
    }
}