namespace eTicaret.Core.IUnitOfWorks;

public interface IUnitOfWork
{
    Task CommitAsync();

    void Commit();
}