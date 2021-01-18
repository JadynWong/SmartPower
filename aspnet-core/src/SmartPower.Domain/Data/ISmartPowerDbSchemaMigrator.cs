using System.Threading.Tasks;

namespace SmartPower.Data
{
    public interface ISmartPowerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
