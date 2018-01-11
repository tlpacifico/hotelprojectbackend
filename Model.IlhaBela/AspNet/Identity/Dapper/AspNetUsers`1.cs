// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.AspNetUsers`1
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AspNet.Identity.Dapper
{
  public class AspNetUsers<TUser> : IDisposable where TUser : IdentityMember
  {
    private DbManager db;

    public AspNetUsers(DbManager database)
    {
      this.db = database;
    }

    public string GetUserName(string memberId)
    {
      return this.db.Connection.ExecuteScalar<string>("Select Name from AspNetUsers where Id=@MemberId", (object) new
      {
        MemberId = memberId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public string GetmemberId(string userName)
    {
      return this.db.Connection.ExecuteScalar<string>("Select Id from AspNetUsers where UserName=@UserName", (object) new
      {
        UserName = userName
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public TUser GetUserById(string memberId)
    {
      return this.db.Connection.Query<TUser>("Select * from AspNetUsers where Id=@MemberId", (object) new
      {
        MemberId = memberId
      }, (IDbTransaction) null, true, new int?(), new CommandType?()).FirstOrDefault<TUser>();
    }

    public IQueryable<TUser> GetAllUser()
    {
      return this.db.Connection.Query<TUser>("Select * from AspNetUsers", (object) null, (IDbTransaction) null, true, new int?(), new CommandType?()).AsQueryable<TUser>();
    }

    public List<TUser> GetUserByName(string userName)
    {
      return this.db.Connection.Query<TUser>("Select * from AspNetUsers where UserName=@UserName", (object) new
      {
        UserName = userName
      }, (IDbTransaction) null, true, new int?(), new CommandType?()).ToList<TUser>();
    }

    public TUser GetUserByEmail(string email)
    {
      return this.db.Connection.Query<TUser>("Select * from AspNetUsers where Email=@Email", (object) new
      {
        Email = email
      }, (IDbTransaction) null, true, new int?(), new CommandType?()).FirstOrDefault<TUser>();
    }

    public string GetPasswordHash(string memberId)
    {
      return this.db.Connection.ExecuteScalar<string>("Select PasswordHash from AspNetUsers where Id = @MemberId", (object) new
      {
        MemberId = memberId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public void SetPasswordHash(string memberId, string passwordHash)
    {
      this.db.Connection.Execute("\r\n                    UPDATE\r\n                        AspNetUsers\r\n                    SET\r\n                        PasswordHash = @pwdHash\r\n                    WHERE\r\n                        Id = @Id", (object) new
      {
        pwdHash = passwordHash,
        Id = memberId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public string GetSecurityStamp(string memberId)
    {
      return this.db.Connection.ExecuteScalar<string>("Select SecurityStamp from AspNetUsers where Id = @MemberId", (object) new
      {
        MemberId = memberId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public void Insert(TUser member)
    {
      string str = this.db.Connection.ExecuteScalar<string>("Insert into AspNetUsers\r\n                                    (Id, UserName,  PasswordHash, SecurityStamp,Email,EmailConfirmed,PhoneNumber,PhoneNumberConfirmed, AccessFailedCount,LockoutEnabled,LockoutEndDateUtc,TwoFactorEnabled,CdCnpjCpf, NmUsuario)\r\n                            values  (@Id, @name, @pwdHash, @SecStamp,@email,@emailconfirmed,@phonenumber,@phonenumberconfirmed,@accesscount,@lockoutenabled,@lockoutenddate,@twofactorenabled,@CdCnpjCpf,@NmUsuario)", (object) new
      {
        Id = member.Id,
        name = member.UserName,
        pwdHash = member.PasswordHash,
        SecStamp = member.SecurityStamp,
        email = member.Email,
        emailconfirmed = member.EmailConfirmed,
        phonenumber = member.PhoneNumber,
        phonenumberconfirmed = member.PhoneNumberConfirmed,
        accesscount = member.AccessFailedCount,
        lockoutenabled = member.LockoutEnabled,
        lockoutenddate = member.LockoutEndDateUtc,
        twofactorenabled = member.TwoFactorEnabled,
        CdCnpjCpf = member.CdCnpjcpf,
        NmUsuario = member.NmUsuario
      }, (IDbTransaction) null, new int?(), new CommandType?());
      member.Id = str;
    }

    private void Delete(string memberId)
    {
      this.db.Connection.Execute("Delete from AspNetUsers where Id = @MemberId", (object) new
      {
        MemberId = memberId
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public void Delete(TUser Member)
    {
      this.Delete(Member.Id);
    }

    public void Update(TUser member)
    {
      this.db.Connection.Execute("\r\n                            Update AspNetUsers set UserName = @userName, PasswordHash = @pswHash, SecurityStamp = @secStamp, \r\n                Email=@email, EmailConfirmed=@emailconfirmed, PhoneNumber=@phonenumber, PhoneNumberConfirmed=@phonenumberconfirmed,\r\n                AccessFailedCount=@accesscount, LockoutEnabled=@lockoutenabled, LockoutEndDateUtc=@lockoutenddate, TwoFactorEnabled=@twofactorenabled  \r\n                WHERE Id = @memberId", (object) new
      {
        userName = member.UserName,
        pswHash = member.PasswordHash,
        secStamp = member.SecurityStamp,
        memberId = member.Id,
        email = member.Email,
        emailconfirmed = member.EmailConfirmed,
        phonenumber = member.PhoneNumber,
        phonenumberconfirmed = member.PhoneNumberConfirmed,
        accesscount = member.AccessFailedCount,
        lockoutenabled = member.LockoutEnabled,
        lockoutenddate = member.LockoutEndDateUtc,
        twofactorenabled = member.TwoFactorEnabled
      }, (IDbTransaction) null, new int?(), new CommandType?());
    }

    public void Dispose()
    {
      this.db.Connection.Close();
      this.db.Dispose();
    }
  }
}
