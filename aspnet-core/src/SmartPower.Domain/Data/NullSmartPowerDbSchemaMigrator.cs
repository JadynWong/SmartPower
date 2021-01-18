using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SmartPower.Data
{
    /* This is used if database provider does't define
     * ISmartPowerDbSchemaMigrator implementation.
     */
    public class NullSmartPowerDbSchemaMigrator : ISmartPowerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}