namespace InjecaoDeDependencia
{
    public class Operacao : IOperacaoSingleton, IOperacaoScopped, IOperacaoTransient
    {
        public Guid Id { get; set; }

        public Operacao()
        {
            Id = Guid.NewGuid();
        }
    }
}
