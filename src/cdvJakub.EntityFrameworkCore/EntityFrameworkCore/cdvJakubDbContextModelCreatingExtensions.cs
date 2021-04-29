using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace cdvJakub.EntityFrameworkCore
{
    public static class cdvJakubDbContextModelCreatingExtensions
    {
        public static void ConfigurecdvJakub(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(cdvJakubConsts.DbTablePrefix + "YourEntities", cdvJakubConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}