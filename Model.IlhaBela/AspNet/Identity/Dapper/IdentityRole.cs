// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.IdentityRole
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Microsoft.AspNet.Identity;

namespace AspNet.Identity.Dapper
{
  public class IdentityRole : IRole<int>
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public IdentityRole()
    {
    }

    public IdentityRole(string name)
      : this()
    {
      this.Name = name;
    }

    public IdentityRole(string name, int id)
    {
      this.Name = name;
      this.Id = id;
    }
  }
}
