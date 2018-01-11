using Domain.Entity;
using Domain.Repository.Abstract;
using Domain.Repository.Concreto;
using Domain.UnitofWork;
using MicroOrm.Pocos.SqlGenerator;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Domain.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ICamaRepository _camaRepository;

        private bool disposed;

        public IDbConnection connection { get; set; }

        #region CamaRepository
        public ICamaRepository CamaRepository
        {
            get
            {
                if (_camaRepository == null)
                    _camaRepository = new CamaRepository(connection, new SqlGenerator<Cama>());
                return _camaRepository;
            }
        }
        #endregion



        public UnitOfWork()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["IlhaBelaCs"].ToString());
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                connection.Close();
                connection.Dispose();
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
