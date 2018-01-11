// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.DbManager
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AspNet.Identity.Dapper
{
  public class DbManager : IDisposable
  {
    private IDbConnection _conn { get; set; }

    public IDbConnection Connection
    {
      get
      {
        if (this._conn.State == ConnectionState.Closed)
          this._conn.Open();
        return this._conn;
      }
    }

    public DbManager(string connString)
    {
      if (connString == "")
        connString = ConfigurationManager.ConnectionStrings[0].Name;
      this._conn = (IDbConnection) new SqlConnection(connString);
    }

    public void Dispose()
    {
      if (this._conn == null)
        return;
      if (this._conn.State == ConnectionState.Open)
      {
        this._conn.Close();
        this._conn.Dispose();
      }
      this._conn = (IDbConnection) null;
    }
  }
}
