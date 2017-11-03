using IdentityServer3.Core;
using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityServer3Example.Models
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
            new Client
            {
                Enabled = true,
                ClientName = "MVC Client",
                ClientId = "mvc",
                Flow = Flows.Implicit,

                RedirectUris = new List<string>
                {
                    "https://localhost:44318/"
                },

                AllowAccessToAllScopes = true,
                PostLogoutRedirectUris = new List<string>
                {
                    "https://localhost:44318/"
                }
            }
         };
       }
    }
    //public static class Clients
    //{
    //    public static IEnumerable<Client> Get()
    //    {
    //        return new[]
    //        {
    //     new Client
    //            {
    //                ClientName = "JavaScript Implicit Client - UserManager",
    //                ClientId = "js.usermanager",
    //                Flow = Flows.Implicit,

    //                AllowedScopes = new List<string>
    //                {
    //                    Constants.StandardScopes.OpenId,
    //                    Constants.StandardScopes.Profile,
    //                    Constants.StandardScopes.Email,
    //                    Constants.StandardScopes.Roles,
    //                    "read",
    //                    "write"
    //                },

    //                ClientUri = "http://identityserver.io",

    //                RequireConsent = true,
    //                AllowRememberConsent = true,

    //                RedirectUris = new List<string>
    //                {
    //                    "http://localhost:21575/index.html",
    //                    "http://localhost:21575/silent_renew.html",
    //                    "http://localhost:21575/callback.html",
    //                    "http://localhost:21575/frame.html",
    //                    "http://localhost:21575/popup.html",
    //                },

    //                PostLogoutRedirectUris = new List<string>
    //                {
    //                    "http://localhost:21575/index.html",
    //                },

    //                AllowedCorsOrigins = new List<string>
    //                {
    //                    "http://localhost:21575",
    //                },

    //                AccessTokenLifetime = 3600,
    //                AccessTokenType = AccessTokenType.Jwt
    //            },
    //    };
    //    }
}
