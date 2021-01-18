using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace SmartPower.EntityFrameworkCore
{
    public static class SmartPowerDbContextModelCreatingExtensions
    {
        public static void ConfigureSmartPower(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SmartPowerConsts.DbTablePrefix + "YourEntities", SmartPowerConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}