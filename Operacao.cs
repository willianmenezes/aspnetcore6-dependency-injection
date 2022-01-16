namespace InjecaoDeDependencia
{
    public class PrimeiraOperacao : IOperacao
    {
        public Guid Id { get; set; }

        public PrimeiraOperacao()
        {
            Id = Guid.NewGuid();
        }
    }

    public class SegundaOperacao : IOperacao
    {
        public Guid Id { get; set; }

        public SegundaOperacao()
        {
            Id = Guid.NewGuid();
        }
    }

    public class TerceiraOperacao : IOperacao
    {
        public Guid Id { get; set; }

        public TerceiraOperacao()
        {
            Id = Guid.NewGuid();
        }
    }
}
