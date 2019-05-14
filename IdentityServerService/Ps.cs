using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Uow;
using Abp.IdentityServer4;
using Abp.Runtime.Security;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using TestProject.Authorization.Roles;
using TestProject.Authorization.Users;

namespace IdentityServerService
{
    public class Ps : AbpProfileService<User>
    {
        private readonly UserManager _userManager;
        private readonly IActiveUnitOfWork _unitOfWorkManager;

        public Ps(UserManager<User> userManager, IUserClaimsPrincipalFactory<User> claimsFactory, IUnitOfWorkManager unitOfWorkManager) : base(userManager, claimsFactory, unitOfWorkManager)
        {
        }
    }
}
