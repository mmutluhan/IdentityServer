using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace DreamBits.Merada.IdentityServer.Web
{
    public class Config
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
            };
        }

        // scopes define the API resources in your system
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new("merada.blog.api", "merada.blog.api"),
                new("merada.shopping.api", "merada.shopping.api")
            };
        }

        // client want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            // client credentials client
            return new List<Client>
            {
                new()
                {
                    ClientId = "merada.shopping.web",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowOfflineAccess = true,
                    ClientSecrets =
                    {
                        new Secret("secret-web".Sha256())
                    },
                    AllowedScopes = {"merada.shopping.web", IdentityServerConstants.StandardScopes.OfflineAccess}
                },
                new()
                {
                    ClientId = "merada.shopping.mobile",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowOfflineAccess = true,
                    ClientSecrets =
                    {
                        new Secret("secret-mobile".Sha256())
                    },
                    AllowedScopes = {"merada.shopping.mobile", IdentityServerConstants.StandardScopes.OfflineAccess}
                },
                new()
                {
                    ClientId = "merada.shopping.api",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowOfflineAccess = true,
                    ClientSecrets =
                    {
                        new Secret("secret-shopping".Sha256())
                    },
                    AllowedScopes = {"merada.shopping.api", IdentityServerConstants.StandardScopes.OfflineAccess}
                }
            };
        }
    }
}