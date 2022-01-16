namespace InjecaoDeDependencia
{
    public class Operacao : IOperacao
    {
        public Guid Id { get; set; }

        public Operacao()
        {
            Id = Guid.NewGuid();
        }

        public Operacao(Guid guid)
        {
            Id = guid;
        }
    }
}
