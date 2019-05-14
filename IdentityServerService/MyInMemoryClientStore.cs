using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Extensions;
using IdentityServer4.Stores;

namespace IdentityServerService
{
    public class MyInMemoryClientStore : IClientStore
    {
        private readonly IEnumerable<IdentityServer4.Models.Client> _clients;

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryClientStore"/> class.
        /// </summary>
        /// <param name="clients">The clients.</param>
        public MyInMemoryClientStore(IEnumerable<IdentityServer4.Models.Client> clients)
        {
            if (clients.HasDuplicates(m => m.ClientId))
            {
                throw new ArgumentException("Clients must not contain duplicate ids");
            }
            _clients = clients;
        }

        /// <summary>
        /// Finds a client by id
        /// </summary>
        /// <param name="clientId">The client id</param>
        /// <returns>
        /// The client
        /// </returns>
        public Task<IdentityServer4.Models.Client> FindClientByIdAsync(string clientId)
        {
            var query =
                from client in _clients
                where client.ClientId == clientId
                select client;

            return Task.FromResult(query.SingleOrDefault());
        }
    }
}
