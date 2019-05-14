using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityServerService.Client
{
    internal class Clients
    {
        public static IEnumerable<IdentityServer4.Models.Client> Get()
        {
            return new List<IdentityServer4.Models.Client>
            {
                //new IdentityServer4.Models.Client
                //{
                //    ClientId = "oauthClient",
                //    ClientName = "Example Client Credentials Client Application",
                //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                //    ClientSecrets = new List<Secret>
                //    {
                //        new Secret("superSecretPassword".Sha256())
                //    },
                //    AllowedScopes = new List<string> {"customAPI.read"}
                //},
                //new IdentityServer4.Models.Client
                //{
                //    ClientId = "mvcApp",
                //    ClientName = "Other Client to connect",
                //    // Tip aplikacije | Kako aplikacija komunicira sa token serverom
                //    // Implicit = samo putem browsera | FrontChannel
                //    AllowedGrantTypes = GrantTypes.Hybrid,
                //    ClientSecrets = {new Secret("secret".Sha256())},
                //    RequireConsent = false,
                //    RedirectUris = new List<string>{"http://localhost:58177/signin-oidc"},
                //    AllowedScopes = new List<string>
                //    {
                //        IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile,
                //        IdentityServerConstants.StandardScopes.Email,
                //        "role",
                //        "customAPI.write",
                //        "abptenantid"
                //    },
                //    FrontChannelLogoutUri = "http://localhost:58177/signout-oidc",
                //    PostLogoutRedirectUris = {"http://localhost:58177/signout-callback-oidc"},
                //    AllowOfflineAccess = true
                //},
                //new IdentityServer4.Models.Client
                //{
                //    ClientId = "officeBoilerProject",
                //    ClientName = "MVC Office ",
                //    AllowedGrantTypes = GrantTypes.Implicit,
                //    ClientSecrets = {new Secret("secret".Sha256())},
                //    RequireClientSecret = false,
                //    RedirectUris = {"http://127.0.0.1:5000/signin-oidc"},
                //    FrontChannelLogoutUri = "http://127.0.0.1:5000/signout-oidc",
                //    PostLogoutRedirectUris = {"http://127.0.0.1:5000/signout-callback-oidc"},
                //    AllowedScopes =
                //    {
                //        IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile,
                //        IdentityServerConstants.StandardScopes.Email,
                //        "abptenantid"
                //    }
                //}
            };
        }
    }
}