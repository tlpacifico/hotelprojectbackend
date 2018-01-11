// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.RoleStore`1
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Microsoft.AspNet.Identity;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet.Identity.Dapper
{
  public class RoleStore<TRole> : IQueryableRoleStore<TRole, int>, IRoleStore<TRole, int>, IDisposable where TRole : IdentityRole
  {
    private AspNetRoles roleTable;

    public DbManager Database { get; private set; }

    public IQueryable<TRole> Roles
    {
      get
      {
        throw new NotImplementedException();
      }
    }

    public RoleStore()
    {
      RoleStore<TRole> roleStore = new RoleStore<TRole>(new DbManager(ConfigurationManager.ConnectionStrings["IlhaBelaCs"].ConnectionString));
    }

    public RoleStore(DbManager database)
    {
      this.Database = database;
      this.roleTable = new AspNetRoles(database);
    }

    public Task CreateAsync(TRole role)
    {
      if ((object) role == null)
        throw new ArgumentNullException("role");
      this.roleTable.Insert((IdentityRole) role);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task DeleteAsync(TRole role)
    {
      if ((object) role == null)
        throw new ArgumentNullException("user");
      this.roleTable.Delete(role.Id);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task<TRole> FindByIdAsync(int roleId)
    {
      return Task.FromResult<TRole>(this.roleTable.GetRoleById(roleId) as TRole);
    }

    public Task<TRole> FindByNameAsync(string roleName)
    {
      return Task.FromResult<TRole>(this.roleTable.GetRoleByName(roleName) as TRole);
    }

    public Task UpdateAsync(TRole role)
    {
      if ((object) role == null)
        throw new ArgumentNullException("user");
      this.roleTable.Update((IdentityRole) role);
      return (Task) Task.FromResult<object>((object) null);
    }

    public void Dispose()
    {
      if (this.Database == null)
        return;
      this.Database.Dispose();
      this.Database = (DbManager) null;
    }
  }
}
