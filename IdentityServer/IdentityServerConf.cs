using IdentityModel;
using IdentityServer4.Models;
using System.Collections;
using System.Collections.Generic;

namespace IdentityServer
{
    public class IdentityServerConf
    {
        public static IEnumerable<Client> GetClients() =>
            new List<Client>()
            {
                new Client()
                {
                    ClientId =  "client_id",
                    ClientSecrets ={ new Secret("client_secrets".ToSha256())},
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    
                    AllowedScopes = {
                        "OrdersApi"
                    }
                }
            };

        public static IEnumerable<ApiScope> GetApiScopes() =>
            new List<ApiScope>()
            {
                new ApiScope("OrdersApi")
            };

        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>()
            {
                new ApiResource("OrdersApi")
            };


        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource>()
            {
                new IdentityResources.OpenId()
            };
    }
}
