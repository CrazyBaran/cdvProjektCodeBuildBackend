using System.Threading.Tasks;

namespace cdvJakub.Data
{
    public interface IcdvJakubDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
