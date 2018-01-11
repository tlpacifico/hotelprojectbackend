using System;
using System.Data;

namespace Domain
{
  public class DataConnection : IDisposable
  {
    private IDbConnection _connection;

    protected IDbConnection Connection
    {
      get
      {
        if (this._connection.State != ConnectionState.Open && this._connection.State != ConnectionState.Connecting)
          this._connection.Open();
        return this._connection;
      }
    }

    public DataConnection(IDbConnection connection)
    {
      this._connection = connection;
    }

    public void Dispose()
    {
      if (this._connection == null || this._connection.State == ConnectionState.Closed)
        return;
      this._connection.Close();
    }
  }
}
