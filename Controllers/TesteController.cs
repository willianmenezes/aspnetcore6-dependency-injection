using Microsoft.AspNetCore.Mvc;

namespace InjecaoDeDependencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private readonly ILogger<TesteController> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly IOperacao _operacao;

        public TesteController(ILogger<TesteController> logger, IServiceProvider services, IOperacao operacao)
        {
            _logger = logger;
            _serviceProvider = services;
            _operacao = operacao;
        }    
        
        [HttpGet("FromServices")]
        public IActionResult GetFromServices([FromServices] IOperacao operacao)
        {
            return Ok(operacao.Id);
        }

        [HttpGet("FromServiceProviver")]
        public IActionResult GetServiceCollection()
        {
            var operacao = _serviceProvider.GetRequiredService<IOperacao>();

            return Ok(operacao.Id);
        }

        [HttpGet("FromConstructor")]
        public IActionResult GetFromConstructor()
        {
            return Ok(_operacao.Id);
        }
    }
}