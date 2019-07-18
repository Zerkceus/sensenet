﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SenseNet.ContentRepository;
using SenseNet.ContentRepository.Storage;

namespace SenseNet.Identity
{
    public static class IdentityExtensions
    {
        public static IdentityBuilder AddSenseNetIdentity(this IServiceCollection services, string parentPath, string[] groupPaths = null)
        {
            var store = new SnUserStore(parentPath, groupPaths);

            return services.AddSenseNetIdentity(store);
        }
        public static IdentityBuilder AddSenseNetIdentity(this IServiceCollection services, Func<SnIdentityUser, Task<Node>> getParentCallback)
        {
            var store = new SnUserStore(getParentCallback);

            return services.AddSenseNetIdentity(store);
        }
        public static IdentityBuilder AddSenseNetIdentity(this IServiceCollection services,
            Func<SnIdentityUser, Task<Node>> getParentCallback,
            Func<User, Task<Group[]>> getGroupsCallback)
        {
            var store = new SnUserStore(getParentCallback, getGroupsCallback);

            return services.AddSenseNetIdentity(store);
        }

        public static IdentityBuilder AddSenseNetIdentity(this IServiceCollection services, SnUserStore userStore = null)
        {
            services.AddSingleton<IUserStore<SnIdentityUser>>(userStore ?? new SnUserStore());
            services.AddSingleton<IRoleStore<SnIdentityRole>>(new SnRoleStore());

            //SignInManager and HttpContextAccessor are configured by AddIdentity below.
            return services.AddIdentity<SnIdentityUser, SnIdentityRole>()
                .AddDefaultTokenProviders();
        }
    }
}