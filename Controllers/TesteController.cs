using Microsoft.AspNetCore.Mvc;

namespace InjecaoDeDependencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly IOperacaoScopped _scopped;
        private readonly IOperacaoSingleton _singleton;
        private readonly IOperacaoTransient _transient;

        public TesteController(
            IOperacaoScopped scopped,
            IOperacaoSingleton singleton,
            IOperacaoTransient transient)
        {
            _scopped = scopped;
            _singleton = singleton;
            _transient = transient;
        }

        [HttpGet("FromConstructor")]
        public IActionResult GetFromConstructor(
            [FromServices] IOperacaoTransient t,
            [FromServices] IOperacaoSingleton sin,
            [FromServices] IOperacaoScopped s
            )
        {
            return Ok(new
            {
                Request01 = new
                {
                    Transient = _transient.Id,
                    Scopped = _scopped.Id,
                    Singleton = _singleton.Id
                },
                Request02 = new
                {
                    Transient = t.Id,
                    Scopped = s.Id,
                    Singleton = sin.Id
                }
            });
        }
    }
}