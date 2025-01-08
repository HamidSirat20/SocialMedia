namespace Business.src.BusinessInterface;

public interface IBaseRepo<T, TRead, TCreate, TUpdate>
{
    Task<ICollection<TRead>> GetAll();
    Task<TRead> GetOne();
    Task<bool> Create(TCreate create);
    Task<bool> Update(Guid guid, TUpdate update);
    Task<bool> Delete(Guid guid);

}
