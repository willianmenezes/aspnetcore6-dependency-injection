using Microsoft.AspNetCore.Mvc;

namespace InjecaoDeDependencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly IOperacao _operacao;
        private readonly IEnumerable<IOperacao> _operacoes;

        public TesteController(IOperacao operacao, IEnumerable<IOperacao> operacoes)
        {
            _operacao = operacao;
            _operacoes = operacoes;
        }

        [HttpGet("FromConstructor")]
        public IActionResult GetFromConstructor()
        {
            return Ok(new
            {
                Transient = _operacoes.Where(x => x is PrimeiraOperacao).First().Id,
                Scopped = _operacoes.Where(x => x is SegundaOperacao).First().Id,
                Singleton = _operacoes.Where(x => x is TerceiraOperacao).First().Id
            });
        }
    }
}