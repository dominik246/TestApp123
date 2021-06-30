namespace TestApp123.Core.Repository
{
    public interface IUnitOfWork
    {
        T GetRepository<T>() where T : class;
    }
}