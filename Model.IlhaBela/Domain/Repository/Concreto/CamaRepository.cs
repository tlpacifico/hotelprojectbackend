using Domain.Entity;
using Domain.Repository.Abstract;
using Domain.Repository.Base;
using MicroOrm.Pocos.SqlGenerator;
using System.Data;

namespace Domain.Repository.Concreto
{
    public class CamaRepository : DataRepository<Cama>, ICamaRepository, IDataRepository<Cama>
    {
        public CamaRepository(IDbConnection connection, ISqlGenerator<Cama> sqlGenerator)
          : base(connection, sqlGenerator)
        {
        }
    }
}
