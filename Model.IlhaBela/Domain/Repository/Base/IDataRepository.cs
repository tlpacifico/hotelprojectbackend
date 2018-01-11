using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository.Base
{
  public interface IDataRepository<TEntity> where TEntity : new()
  {
    IEnumerable<TEntity> Query(string sql);

    IEnumerable<TEntity> GetAll();

    IEnumerable<TEntity> GetWhere(object filters);

    TEntity GetFirst(object filters);

    bool Insert(TEntity instance);

    bool Delete(object key);

    bool Update(TEntity instance);

    Task<IEnumerable<TEntity>> QueryAsync(string sql);

    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<IEnumerable<TEntity>> GetWhereAsync(object filters);

    Task<TEntity> GetFirstAsync(object filters);

    Task<bool> UpdateAsync(TEntity instance);

    Task<bool> InsertAsync(TEntity instance);

    Task<bool> DeleteAsync(object key);
  }
}
