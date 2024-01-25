using System.Threading.Tasks;

namespace Acme.Emenu.Data;

public interface IEmenuDbSchemaMigrator
{
    Task MigrateAsync();
}
