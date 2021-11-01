using System.Threading.Tasks;

namespace BeniceSoft.GoldenToad.Data
{
    public interface IGoldenToadDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
