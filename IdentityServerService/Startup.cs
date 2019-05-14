using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Abp.AspNetCore;
using Abp.AutoMapper;
using Abp.Castle.Logging.Log4Net;
using Abp.IdentityServer4;
using AutoMapper;
using Castle.Facilities.Logging;
using IdentityServer4.Services;
using IdentityServerService.Client;
using IdentityServerService.Resource;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestProject.Authorization.Users;
using TestProject.Configuration;
using TestProject.EntityFrameworkCore;
using TestProject.Identity;

namespace IdentityServerService
{
    public class Startup
    {
        private readonly IConfigurationRoot _configuration;
        
        public Startup(IHostingEnvironment env)
        {
            _configuration = env.GetAppConfiguration();

            //IConfigurationSection section = _configuration.GetSection("IdentityServerService:Clients");

            //var clients = new List<Clients>();
            //section.Bind(clients);
        }

        //public List<IdentityServer4.Models.Client> Add()
        //{
        //    IConfigurationSection section = _configuration.GetSection("IdentityService:Clients");

        //    //var dto = new IdentityServiceConfigurationDto();
        //    //section.Bind(dto);
        //    var clients = new List<IdentityServer4.Models.Client>();
        //    section.Bind(clients);
        //    return clients;
        //}

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            IdentityRegistrar.Register(services);

            //IConfigurationSection _section = _configuration.GetSection("IdentityServerService:Clients");

            //var clients = new List<Clients>();
            //_section.Bind(clients);

            services.AddMvc();
            //services.Configure<List<IdentityServer4.Models.Client>>(_configuration.GetSection("IdentityServer:Clients"));

            var clients = new List<ClientDto>();
            var section = _configuration.GetSection("IdentityService:Clients");
            section.Bind(clients);
            services.AddSingleton((IEnumerable<IdentityServer4.Models.Client>)clients);

            services.AddIdentityServer()
                //.AddInMemoryClients(_configuration.GetSection("IdentityService:Clients"))
                .AddClientStore<MyInMemoryClientStore>()
                .AddInMemoryIdentityResources(Resources.GetIdentityResources()) //iz koda, ne u bazu
                .AddInMemoryApiResources(Resources.GetApiResources())
                .AddDeveloperSigningCredential()
                .AddAbpPersistedGrants<TestProjectDbContext>()
                .AddAbpIdentityServer<User>()
                .AddProfileService<Ps>();
                //.AddProfileService<MyProfileService>();

            return services.AddAbp<IdentityServerServiceModule>(
                // Configure Log4Net logging
                options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                )
            );
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseAbp();
            app.UseStaticFiles();
            app.UseIdentityServer();
            app.UseMvcWithDefaultRoute();

            app.Run(async context =>
            {
                //await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}