// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.AspNetRoles
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Dapper;
using System.Data;

namespace AspNet.Identity.Dapper
{
  public class AspNetRoles
  {
    private DbManager db;

    public AspNetRoles(DbManager database)
    {
      this.db = database;
    }

    public void Delete(int roleId)
    {
      this.db.Connection.Execute("Delete from AspNetRoles where Id = @id", (object) new
      {
        id = roleId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public void Insert(IdentityRole role)
    {
      this.db.Connection.Execute("Insert into AspNetRoles (Name) values (@name)", (object) new
      {
        name = role.Name
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public string GetRoleName(int roleId)
    {
      return this.db.Connection.ExecuteScalar<string>("Select AspNetRoles from Role where Id=@id", (object) new
      {
        id = roleId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public int GetRoleId(string roleName)
    {
      return this.db.Connection.ExecuteScalar<int>("Select Id from AspNetRoles where Name=@name", (object) new
      {
        name = roleName
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public IdentityRole GetRoleById(int roleId)
    {
      string roleName = this.GetRoleName(roleId);
      IdentityRole identityRole = (IdentityRole) null;
      if (roleName != null)
        identityRole = new IdentityRole(roleName, roleId);
      return identityRole;
    }

    public IdentityRole GetRoleByName(string roleName)
    {
      int roleId = this.GetRoleId(roleName);
      IdentityRole identityRole = (IdentityRole) null;
      if (roleId > 0)
        identityRole = new IdentityRole(roleName, roleId);
      return identityRole;
    }

    public void Update(IdentityRole role)
    {
      this.db.Connection.Execute("\r\n                    UPDATE AspNetRoles\r\n                    SET\r\n                        Name = @name\r\n                    WHERE\r\n                        Id = @id", (object) new
      {
        name = role.Name,
        id = role.Id
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }
  }
}
