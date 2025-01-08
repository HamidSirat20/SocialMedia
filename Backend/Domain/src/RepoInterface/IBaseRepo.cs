namespace Domain.src.RepoInterface;

public interface IBaseRepo<T>
{
    Task<ICollection<T>> GetAll();
    Task<T> GetOne();
    Task<bool> Create(T create);
    Task<bool> Update(Guid guid, T update);
    Task<bool> Delete(Guid guid);

}
