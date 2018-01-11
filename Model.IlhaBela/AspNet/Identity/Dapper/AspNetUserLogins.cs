// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.AspNetUserLogins
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Dapper;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AspNet.Identity.Dapper
{
  public class AspNetUserLogins
  {
    private DbManager db;

    public AspNetUserLogins(DbManager database)
    {
      this.db = database;
    }

    public void Delete(IdentityMember member, UserLoginInfo login)
    {
      this.db.Connection.Execute("Delete from AspNetUserLogins \r\n                    where UserId = @userId \r\n                    and LoginProvider = @loginProvider \r\n                    and ProviderKey = @providerKey", (object) new
      {
        userId = member.Id,
        loginProvider = login.LoginProvider,
        providerKey = login.ProviderKey
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public void Delete(int userId)
    {
      this.db.Connection.Execute("Delete from AspNetUserLogins \r\n                    where UserId = @userId", (object) new
      {
        userId = userId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public void Insert(IdentityMember member, UserLoginInfo login)
    {
      this.db.Connection.Execute("Insert into AspNetUserLogins \r\n                (LoginProvider, ProviderKey, UserId) \r\n                values (@loginProvider, @providerKey, @userId)", (object) new
      {
        loginProvider = login.LoginProvider,
        providerKey = login.ProviderKey,
        userId = member.Id
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public string FindUserIdByLogin(UserLoginInfo MemberLogin)
    {
      return this.db.Connection.ExecuteScalar<string>("Select UserId from AspNetUserLogins \r\n                where LoginProvider = @loginProvider and ProviderKey = @providerKey", (object) new
      {
        loginProvider = MemberLogin.LoginProvider,
        providerKey = MemberLogin.ProviderKey
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public List<UserLoginInfo> FindByUserId(string memberId)
    {
      return this.db.Connection.Query<UserLoginInfo>("Select * from AspNetUserLogins where UserId = @memberId", (object) new
      {
        memberId = memberId
      }, (IDbTransaction) null, true, new int?(), new CommandType?()).ToList<UserLoginInfo>();
    }
  }
}
