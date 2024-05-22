using System.Threading.Tasks;

namespace PlayGround.Data;

public interface IPlayGroundDbSchemaMigrator
{
    Task MigrateAsync();
}
