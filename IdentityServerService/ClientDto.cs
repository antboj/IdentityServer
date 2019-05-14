using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AutoMapper;
using IdentityServer4.Models;

namespace IdentityServerService
{
    public class ClientDto : IdentityServer4.Models.Client
    {
        public new ICollection<string> ClientSecrets
        {
            get { return base.ClientSecrets.Select(x => x.Value).ToList(); }

            set { base.ClientSecrets = value.Select(x => new Secret(x.Sha256())).ToList(); }
        }
    }
}
