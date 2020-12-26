using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SmartPower.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class SmartPowerMigrationsDbContextFactory : IDesignTimeDbContextFactory<SmartPowerMigrationsDbContext>
    {
        public SmartPowerMigrationsDbContext CreateDbContext(string[] args)
        {
            SmartPowerEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<SmartPowerMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new SmartPowerMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SmartPower.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
