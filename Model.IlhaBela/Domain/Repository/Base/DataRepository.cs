using Dapper;
using MicroOrm.Pocos.SqlGenerator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repository.Base
{
  public abstract class DataRepository<TEntity> : DataConnection, IDataRepository<TEntity> where TEntity : new()
  {
    protected ISqlGenerator<TEntity> SqlGenerator { get; private set; }

    protected DataRepository(IDbConnection connection, ISqlGenerator<TEntity> sqlGenerator)
      : base(connection)
    {
      this.SqlGenerator = sqlGenerator;
    }

    public virtual IEnumerable<TEntity> Query(string sql)
    {
      return this.Connection.Query<TEntity>(sql, (object) null, (IDbTransaction) null, true, new int?(), new CommandType?());
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
      return this.Connection.Query<TEntity>(this.SqlGenerator.GetSelectAll(), (object) null, (IDbTransaction) null, true, new int?(), new CommandType?());
    }

    public virtual IEnumerable<TEntity> GetWhere(object filters)
    {
      return this.Connection.Query<TEntity>(this.SqlGenerator.GetSelect(filters, new int?()), filters, (IDbTransaction) null, true, new int?(), new CommandType?());
    }

    public virtual TEntity GetFirst(object filters)
    {
      return this.GetWhere(filters).FirstOrDefault<TEntity>();
    }

    public virtual bool Insert(TEntity instance)
    {
      string insert = this.SqlGenerator.GetInsert();
      bool flag;
      if (this.SqlGenerator.IsIdentity)
      {
        Decimal num = this.Connection.Query<Decimal>(insert, (object) instance, (IDbTransaction) null, true, new int?(), new CommandType?()).Single<Decimal>();
        flag = num > Decimal.Zero;
        if (flag)
        {
          object obj = Convert.ChangeType((object) num, this.SqlGenerator.IdentityProperty.PropertyInfo.PropertyType);
          this.SqlGenerator.IdentityProperty.PropertyInfo.SetValue((object) instance, obj);
        }
      }
      else
        flag = this.Connection.Execute(insert, (object) instance, (IDbTransaction) null, new int?(), new CommandType?()) > 0;
      return flag;
    }

    public virtual bool Delete(object key)
    {
      return this.Connection.Execute(this.SqlGenerator.GetDelete(), key, (IDbTransaction) null, new int?(), new CommandType?()) > 0;
    }

    public virtual bool Update(TEntity instance)
    {
      return this.Connection.Execute(this.SqlGenerator.GetUpdate(), (object) instance, (IDbTransaction) null, new int?(), new CommandType?()) > 0;
    }

    public virtual async Task<IEnumerable<TEntity>> QueryAsync(string sql)
    {
      return this.Connection.Query<TEntity>(sql, (object) null, (IDbTransaction) null, true, new int?(), new CommandType?());
    }

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
      return await this.Connection.QueryAsync<TEntity>(this.SqlGenerator.GetSelectAll(), (object) null, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public virtual async Task<IEnumerable<TEntity>> GetWhereAsync(object filters)
    {
      return await this.Connection.QueryAsync<TEntity>(this.SqlGenerator.GetSelect(filters, new int?()), filters, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public virtual async Task<TEntity> GetFirstAsync(object filters)
    {
      return (await this.Connection.QueryAsync<TEntity>(this.SqlGenerator.GetSelect(filters, new int?()), filters, (IDbTransaction) null, new int?(), new CommandType?())).FirstOrDefault<TEntity>();
    }

    public virtual async Task<bool> InsertAsync(TEntity instance)
    {
      string sql = this.SqlGenerator.GetInsert();
      bool flag;
      if (this.SqlGenerator.IsIdentity)
      {
        Decimal num = (await this.Connection.QueryAsync<Decimal>(sql, (object) instance, (IDbTransaction) null, new int?(), new CommandType?())).Single<Decimal>();
        flag = num > Decimal.Zero;
        if (flag)
          this.SqlGenerator.IdentityProperty.PropertyInfo.SetValue((object) instance, Convert.ChangeType((object) num, this.SqlGenerator.IdentityProperty.PropertyInfo.PropertyType));
      }
      else
        flag = (await this.Connection.QueryAsync<int>(sql, (object) instance, (IDbTransaction) null, new int?(), new CommandType?())).Single<int>() > 0;
      return flag;
    }

    public virtual async Task<bool> DeleteAsync(object key)
    {
      return (await this.Connection.QueryAsync<int>(this.SqlGenerator.GetDelete(), key, (IDbTransaction) null, new int?(), new CommandType?())).SingleOrDefault<int>() > 0;
    }

    public virtual async Task<bool> UpdateAsync(TEntity instance)
    {
      return (await this.Connection.QueryAsync<int>(this.SqlGenerator.GetUpdate(), (object) instance, (IDbTransaction) null, new int?(), new CommandType?())).SingleOrDefault<int>() > 0;
    }
  }
}
