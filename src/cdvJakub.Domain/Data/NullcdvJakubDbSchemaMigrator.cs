using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace cdvJakub.Data
{
    /* This is used if database provider does't define
     * IcdvJakubDbSchemaMigrator implementation.
     */
    public class NullcdvJakubDbSchemaMigrator : IcdvJakubDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}