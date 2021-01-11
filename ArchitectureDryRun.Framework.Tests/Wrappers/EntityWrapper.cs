using ArchitectureDryRun.Framework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureDryRun.Framework.Tests.Wrappers
{
    public class EntityWrapper : IEntity
    {
        public EntityWrapper()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
