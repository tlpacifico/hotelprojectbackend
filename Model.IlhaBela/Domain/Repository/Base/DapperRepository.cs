using System.Data;

namespace Domain.Repository.Base
{
  public abstract class DapperRepository : DataConnection, IDapperRepository
  {
    protected DapperRepository(IDbConnection connection)
      : base(connection)
    {
    }
  }
}
