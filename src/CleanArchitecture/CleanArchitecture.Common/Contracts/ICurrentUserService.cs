//////////////////////////////////////////////////////////////////////////////
/////////// PBW Web Architects, LLC
/////////// Project:
/////////// Ver:
//////////////////////////////////////////////////////////////////////////////
/////////// Architect/ Analyst: Cesar L Diaz
//////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Common
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        bool IsAuthenticated { get; }
        IEnumerable<string> Roles { get; }
        string IdentityCard { get; }
        DateTime LastLoginDate { get; }
        string CompleteName { get; }
        string EmailAddress { get; }

        Task<string> ClearUser(string userId);

        Task<string> GetUserEmail(string userId);
    }
}