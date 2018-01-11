// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.AspNetUserRoles
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AspNet.Identity.Dapper
{
  public class AspNetUserRoles
  {
    private DbManager db;

    public AspNetUserRoles(DbManager database)
    {
      this.db = database;
    }

    public List<string> FindByUserId(string memberId)
    {
      return this.db.Connection.Query<string>("Select AspNetRoles.Name from AspNetUserRoles, AspNetRoles\r\n                                                    where AspNetUserRoles.UserId=@MemberId and AspNetUserRoles.RoleId = AspNetRoles.Id", (object) new
      {
        MemberId = memberId
      }, (IDbTransaction) null, true, new int?(), new CommandType?()).ToList<string>();
    }

    public void Delete(string memberId)
    {
      this.db.Connection.Execute("Delete from AspNetRoles where RoleId = @MemberId", (object) new
      {
        MemberId = memberId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public void Insert(IdentityMember member, int roleId)
    {
      this.db.Connection.Execute("Insert into AspNetUserRoles (UserId, RoleId) values (@userId, @roleId)", (object) new
      {
        userId = member.Id,
        roleId = roleId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }
  }
}
