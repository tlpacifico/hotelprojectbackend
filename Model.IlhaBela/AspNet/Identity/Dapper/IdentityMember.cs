// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.IdentityMember
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Microsoft.AspNet.Identity;
using System;

namespace AspNet.Identity.Dapper
{
  public class IdentityMember : IUser<string>
  {
    public string Id { get; set; }

    public string UserName { get; set; }

    public virtual string Email { get; set; }

    public virtual bool EmailConfirmed { get; set; }

    public virtual string PasswordHash { get; set; }

    public virtual string SecurityStamp { get; set; }

    public virtual string PhoneNumber { get; set; }

    public virtual bool PhoneNumberConfirmed { get; set; }

    public virtual bool TwoFactorEnabled { get; set; }

    public virtual DateTime? LockoutEndDateUtc { get; set; }

    public virtual bool LockoutEnabled { get; set; }

    public virtual int AccessFailedCount { get; set; }

    public virtual string CdCnpjcpf { get; set; }

    public virtual string IdContaRelacionada { get; set; }

    public virtual DateTime? DtContaRelacionadaAutorizacao { get; set; }

    public virtual string NmUsuario { get; set; }

    public virtual int IdCidade { get; set; }

    public virtual bool FlAlterarSenha { get; set; }

    public IdentityMember()
    {
      this.Id = Guid.NewGuid().ToString();
    }

    public IdentityMember(string userName)
      : this()
    {
      this.UserName = userName;
    }
  }
}
