// Decompiled with JetBrains decompiler
// Type: AspNet.Identity.Dapper.AspNetUserClaims
// Assembly: Domain.EspacoVago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DC649E63-C100-4607-9E0F-BB62FAA2D4E5
// Assembly location: C:\Backup\cliente\bin\Domain.EspacoVago.dll

using Dapper;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace AspNet.Identity.Dapper
{
    public class AspNetUserClaims
    {
        private DbManager db;

        public AspNetUserClaims(DbManager database)
        {
            this.db = database;
        }

        /// <summary>
        /// Returns a ClaimsIdentity instance given a userId
        /// </summary>
        /// <param name="userId">The user's id</param>
        /// <returns></returns>
        public ClaimsIdentity FindByUserId(string memberId)
        {
            ClaimsIdentity claims = new ClaimsIdentity();

            foreach (var c in db.Connection.Query("Select * from MemberClaim where MemberId=@memberId", new { memberId = memberId }))
            {
                claims.AddClaim(new Claim(c.ClaimType, c.ClaimValue));
            }
            return claims;
        }
    

    public void Delete(string memberId)
        {
            this.db.Connection.Execute("Delete from AspNetUserClaims where UserId = @memberId", (object)new
            {
                memberId = memberId
            }, (IDbTransaction)null, new int?(), new CommandType?());
        }

        public void Insert(Claim MemberClaim, string memberId)
        {
            this.db.Connection.Execute("Insert into AspNetUserClaims (ClaimValue, ClaimType, UserId) \r\n                values (@value, @type, @userId)", (object)new
            {
                value = MemberClaim.Value,
                type = MemberClaim.Type,
                userId = memberId
            }, (IDbTransaction)null, new int?(), new CommandType?());
        }

        public void Delete(IdentityMember member, Claim claim)
        {
            this.db.Connection.Execute("Delete from AspNetUserClaims \r\n            where UserId = @memberId and @ClaimValue = @value and ClaimType = @type", (object)new
            {
                memberId = member.Id,
                ClaimValue = claim.Value,
                type = claim.Type
            }, (IDbTransaction)null, new int?(), new CommandType?());
        }
    }
}
