namespace InjecaoDeDependencia
{
    public class Operacao : IOperacao
    {
        public Guid Id { get; set; }

        public Operacao(ILogger<Operacao> logger)
        {
            Id = Guid.NewGuid();
        }

        public Operacao(FooService fooService, BarService barService)
        {
            Id = Guid.NewGuid();
        }
    }

    public class FooService { }
    public class BarService { }
}
