namespace InjecaoDeDependencia
{
    public interface IOperacao
    {
        Guid Id { get; }
    }

    public interface IOperacaoSingleton : IOperacao { }
    public interface IOperacaoTransient : IOperacao { }
    public interface IOperacaoScopped : IOperacao { }
}
