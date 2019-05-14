using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Linq;
using Abp.Organizations;
using TestProject.Authorization.Roles;
using TestProject.Authorization.Users;

namespace IdentityServerService
{
    public class MyUserStore : AbpUserStore<Role, User>
    {
        public MyUserStore(IUnitOfWorkManager unitOfWorkManager, IRepository<User, long> userRepository, IRepository<Role> roleRepository, IAsyncQueryableExecuter asyncQueryableExecuter, IRepository<UserRole, long> userRoleRepository, IRepository<UserLogin, long> userLoginRepository, IRepository<UserClaim, long> userClaimRepository, IRepository<UserPermissionSetting, long> userPermissionSettingRepository, IRepository<UserOrganizationUnit, long> userOrganizationUnitRepository, IRepository<OrganizationUnitRole, long> organizationUnitRoleRepository) : base(unitOfWorkManager, userRepository, roleRepository, asyncQueryableExecuter, userRoleRepository, userLoginRepository, userClaimRepository, userPermissionSettingRepository, userOrganizationUnitRepository, organizationUnitRoleRepository)
        {
        }

        public override Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken = new CancellationToken())
        {
            return base.FindByIdAsync(userId, cancellationToken);
        }
    }
}
