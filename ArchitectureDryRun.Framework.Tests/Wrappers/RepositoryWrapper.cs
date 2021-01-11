using ArchitectureDryRun.Framework.Data;
using ArchitectureDryRun.Framework.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchitectureDryRun.Framework.Tests.Wrappers
{
    public class RepositoryWrapper : Repository<IEntity>
    {
        public RepositoryWrapper(DbContext context) 
            : base(context)
        {
        }
    }
}
