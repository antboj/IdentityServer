using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerService
{
    public class IdentityServiceConfigurationDto
    {
        //public string Name { get; set; }
        public ClientDto[] Clients { get; set; }
    }
}
