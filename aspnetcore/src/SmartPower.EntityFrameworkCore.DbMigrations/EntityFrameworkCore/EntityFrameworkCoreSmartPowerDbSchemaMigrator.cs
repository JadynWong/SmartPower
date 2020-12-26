using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartPower.Data;
using Volo.Abp.DependencyInjection;

namespace SmartPower.EntityFrameworkCore
{
    public class EntityFrameworkCoreSmartPowerDbSchemaMigrator
        : ISmartPowerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSmartPowerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the SmartPowerMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<SmartPowerMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}