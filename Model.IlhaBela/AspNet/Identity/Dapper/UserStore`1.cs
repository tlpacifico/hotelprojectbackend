// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.UserStore`1
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AspNet.Identity.Dapper
{
  public class UserStore<TUser> : IUserLoginStore<TUser, string>, IUserStore<TUser, string>, IDisposable, IUserClaimStore<TUser, string>, IUserRoleStore<TUser, string>, IUserPasswordStore<TUser, string>, IUserSecurityStampStore<TUser, string>, IQueryableUserStore<TUser, string>, IUserEmailStore<TUser, string>, IUserPhoneNumberStore<TUser, string>, IUserTwoFactorStore<TUser, string>, IUserLockoutStore<TUser, string> where TUser : IdentityMember
  {
    private AspNetUsers<TUser> userTable;
    private AspNetRoles roleTable;
    private AspNetUserRoles userRolesTable;
    private AspNetUserClaims userClaimsTable;
    private AspNetUserLogins userLoginsTable;

    public DbManager Database { get; private set; }

    public IQueryable<TUser> Users
    {
      get
      {
        return this.userTable.GetAllUser();
      }
    }

    public UserStore()
    {
      UserStore<TUser> userStore = new UserStore<TUser>(new DbManager(ConfigurationManager.ConnectionStrings["IlhaBelaCs"].ConnectionString));
    }

    public UserStore(DbManager database)
    {
      this.Database = database;
      this.userTable = new AspNetUsers<TUser>(database);
      this.roleTable = new AspNetRoles(database);
      this.userRolesTable = new AspNetUserRoles(database);
      this.userClaimsTable = new AspNetUserClaims(database);
      this.userLoginsTable = new AspNetUserLogins(database);
    }

    public Task CreateAsync(TUser user)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      this.userTable.Insert(user);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task<TUser> FindByIdAsync(string userId)
    {
      TUser userById = this.userTable.GetUserById(userId);
      if ((object) userById != null)
        return Task.FromResult<TUser>(userById);
      return Task.FromResult<TUser>(default (TUser));
    }

    public Task<TUser> FindByNameAsync(string userName)
    {
      if (string.IsNullOrEmpty(userName))
        throw new ArgumentException("Null or empty argument: userName");
      List<TUser> userByName = this.userTable.GetUserByName(userName);
      if (userByName != null && userByName.Count == 1)
        return Task.FromResult<TUser>(userByName[0]);
      return Task.FromResult<TUser>(default (TUser));
    }

    public Task UpdateAsync(TUser user)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      this.userTable.Update(user);
      return (Task) Task.FromResult<object>((object) null);
    }

    public void Dispose()
    {
      if (this.Database == null)
        return;
      this.Database.Dispose();
      this.Database = (DbManager) null;
    }

    public Task AddClaimAsync(TUser user, Claim claim)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      if (claim == null)
        throw new ArgumentNullException("user");
      this.userClaimsTable.Insert(claim, user.Id);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task<IList<Claim>> GetClaimsAsync(TUser user)
    {
      return Task.FromResult<IList<Claim>>((IList<Claim>) this.userClaimsTable.FindByUserId(user.Id).Claims.ToList<Claim>());
    }

    public Task RemoveClaimAsync(TUser user, Claim claim)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      if (claim == null)
        throw new ArgumentNullException("claim");
      this.userClaimsTable.Delete((IdentityMember) user, claim);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task AddLoginAsync(TUser user, UserLoginInfo login)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      if (login == null)
        throw new ArgumentNullException("login");
      this.userLoginsTable.Insert((IdentityMember) user, login);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task<TUser> FindAsync(UserLoginInfo login)
    {
      if (login == null)
        throw new ArgumentNullException("login");
      string userIdByLogin = this.userLoginsTable.FindUserIdByLogin(login);
      if (!string.IsNullOrEmpty(userIdByLogin))
      {
        TUser userById = this.userTable.GetUserById(userIdByLogin);
        if ((object) userById != null)
          return Task.FromResult<TUser>(userById);
      }
      return Task.FromResult<TUser>(default (TUser));
    }

    public Task<IList<UserLoginInfo>> GetLoginsAsync(TUser user)
    {
      List<UserLoginInfo> userLoginInfoList = new List<UserLoginInfo>();
      if ((object) user == null)
        throw new ArgumentNullException("user");
      List<UserLoginInfo> byUserId = this.userLoginsTable.FindByUserId(user.Id);
      if (byUserId != null)
        return Task.FromResult<IList<UserLoginInfo>>((IList<UserLoginInfo>) byUserId);
      return Task.FromResult<IList<UserLoginInfo>>((IList<UserLoginInfo>) null);
    }

    public Task RemoveLoginAsync(TUser user, UserLoginInfo login)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      if (login == null)
        throw new ArgumentNullException("login");
      this.userLoginsTable.Delete((IdentityMember) user, login);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task AddToRoleAsync(TUser user, string roleName)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      if (string.IsNullOrEmpty(roleName))
        throw new ArgumentException("Argument cannot be null or empty: roleName.");
      int roleId = this.roleTable.GetRoleId(roleName);
      if (roleId > 0)
        this.userRolesTable.Insert((IdentityMember) user, roleId);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task<IList<string>> GetRolesAsync(TUser user)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      List<string> byUserId = this.userRolesTable.FindByUserId(user.Id);
      if (byUserId != null)
        return Task.FromResult<IList<string>>((IList<string>) byUserId);
      return Task.FromResult<IList<string>>((IList<string>) null);
    }

    public Task<bool> IsInRoleAsync(TUser user, string role)
    {
      if ((object) user == null)
        throw new ArgumentNullException("user");
      if (string.IsNullOrEmpty(role))
        throw new ArgumentNullException("role");
      List<string> byUserId = this.userRolesTable.FindByUserId(user.Id);
      if (byUserId != null && byUserId.Contains(role))
        return Task.FromResult<bool>(true);
      return Task.FromResult<bool>(false);
    }

    public Task RemoveFromRoleAsync(TUser user, string role)
    {
      throw new NotImplementedException();
    }

    public Task DeleteAsync(TUser user)
    {
      if ((object) user != null)
        this.userTable.Delete(user);
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task<string> GetPasswordHashAsync(TUser user)
    {
      return Task.FromResult<string>(this.userTable.GetPasswordHash(user.Id));
    }

    public Task<bool> HasPasswordAsync(TUser user)
    {
      return Task.FromResult<bool>(bool.Parse((!string.IsNullOrEmpty(this.userTable.GetPasswordHash(user.Id))).ToString()));
    }

    public Task SetPasswordHashAsync(TUser user, string passwordHash)
    {
      user.PasswordHash = passwordHash;
      return (Task) Task.FromResult<object>((object) null);
    }

    public Task SetSecurityStampAsync(TUser user, string stamp)
    {
      user.SecurityStamp = stamp;
      return (Task) Task.FromResult<int>(0);
    }

    public Task<string> GetSecurityStampAsync(TUser user)
    {
      return Task.FromResult<string>(user.SecurityStamp);
    }

    public Task SetEmailAsync(TUser user, string email)
    {
      user.Email = email;
      this.userTable.Update(user);
      return (Task) Task.FromResult<int>(0);
    }

    public Task<string> GetEmailAsync(TUser user)
    {
      return Task.FromResult<string>(user.Email);
    }

    public Task<bool> GetEmailConfirmedAsync(TUser user)
    {
      return Task.FromResult<bool>(user.EmailConfirmed);
    }

    public Task SetEmailConfirmedAsync(TUser user, bool confirmed)
    {
      user.EmailConfirmed = confirmed;
      this.userTable.Update(user);
      return (Task) Task.FromResult<int>(0);
    }

    public Task<TUser> FindByEmailAsync(string email)
    {
      if (string.IsNullOrEmpty(email))
        throw new ArgumentNullException("email");
      TUser userByEmail = this.userTable.GetUserByEmail(email);
      if ((object) userByEmail != null)
        return Task.FromResult<TUser>(userByEmail);
      return Task.FromResult<TUser>(default (TUser));
    }

    public Task SetPhoneNumberAsync(TUser user, string phoneNumber)
    {
      user.PhoneNumber = phoneNumber;
      this.userTable.Update(user);
      return (Task) Task.FromResult<int>(0);
    }

    public Task<string> GetPhoneNumberAsync(TUser user)
    {
      return Task.FromResult<string>(user.PhoneNumber);
    }

    public Task<bool> GetPhoneNumberConfirmedAsync(TUser user)
    {
      return Task.FromResult<bool>(user.PhoneNumberConfirmed);
    }

    public Task SetPhoneNumberConfirmedAsync(TUser user, bool confirmed)
    {
      user.PhoneNumberConfirmed = confirmed;
      this.userTable.Update(user);
      return (Task) Task.FromResult<int>(0);
    }

    public Task SetTwoFactorEnabledAsync(TUser user, bool enabled)
    {
      user.TwoFactorEnabled = enabled;
      this.userTable.Update(user);
      return (Task) Task.FromResult<int>(0);
    }

    public Task<bool> GetTwoFactorEnabledAsync(TUser user)
    {
      return Task.FromResult<bool>(user.TwoFactorEnabled);
    }

    public Task<DateTimeOffset> GetLockoutEndDateAsync(TUser user)
    {
      return Task.FromResult<DateTimeOffset>(user.LockoutEndDateUtc.HasValue ? new DateTimeOffset(DateTime.SpecifyKind(user.LockoutEndDateUtc.Value, DateTimeKind.Utc)) : new DateTimeOffset());
    }

    public Task SetLockoutEndDateAsync(TUser user, DateTimeOffset lockoutEnd)
    {
      user.LockoutEndDateUtc = new DateTime?(lockoutEnd.UtcDateTime);
      this.userTable.Update(user);
      return (Task) Task.FromResult<int>(0);
    }

    public Task<int> IncrementAccessFailedCountAsync(TUser user)
    {
      ++user.AccessFailedCount;
      this.userTable.Update(user);
      return Task.FromResult<int>(user.AccessFailedCount);
    }

    public Task ResetAccessFailedCountAsync(TUser user)
    {
      user.AccessFailedCount = 0;
      this.userTable.Update(user);
      return (Task) Task.FromResult<int>(0);
    }

    public Task<int> GetAccessFailedCountAsync(TUser user)
    {
      return Task.FromResult<int>(user.AccessFailedCount);
    }

    public Task<bool> GetLockoutEnabledAsync(TUser user)
    {
      return Task.FromResult<bool>(user.LockoutEnabled);
    }

    public Task SetLockoutEnabledAsync(TUser user, bool enabled)
    {
      user.LockoutEnabled = enabled;
      this.userTable.Update(user);
      return (Task) Task.FromResult<int>(0);
    }
  }
}
