namespace InjecaoDeDependencia
{
    public interface IOperacao
    {
        Guid Id { get; }
    }

    public class Operacao : IOperacao
    {
        public Guid Id { get; set; }

        public Operacao()
        {
            Id = Guid.NewGuid();
        }
    }
}
