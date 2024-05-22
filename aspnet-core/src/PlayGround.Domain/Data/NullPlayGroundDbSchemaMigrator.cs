using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PlayGround.Data;

/* This is used if database provider does't define
 * IPlayGroundDbSchemaMigrator implementation.
 */
public class NullPlayGroundDbSchemaMigrator : IPlayGroundDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
