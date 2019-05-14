using Abp.Authorization.Users;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using TestProject;
using TestProject.Authorization.Roles;
using TestProject.Authorization.Users;

namespace IdentityServerService
{
    [DependsOn(typeof(TestProjectWebCoreModule))]
    public class IdentityServerServiceModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            //Configuration.ReplaceService(typeof(AbpUserStore<Role, User>), () =>
            //{
            //    IocManager.Register<MyUserStore>(DependencyLifeStyle.Transient);
            //});
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(IdentityServerServiceModule).GetAssembly());
        }
    }
}