using ArchitectureDryRun.Framework.Domain.Entities;
using ArchitectureDryRun.Framework.Tests.Wrappers;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;

namespace ArchitectureDryRun.Framework.Tests
{
    public class RepositoryTests
    {
        private RepositoryWrapper _repository;

        private DbContext _context;

        public RepositoryTests()
        {
            var options = new DbContextOptionsBuilder<DbContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDatabase")
                .Options;

            _context = new DbContext(options);

            _repository = new RepositoryWrapper(_context);
        }

        [Fact]
        public void Should_Add_Item()
        {
            // Arrange
            var entity = new EntityWrapper();
            

            // Act
            _repository.Add(entity);

            // Assert
            var added = _context.Set<EntityWrapper>().Find(entity.Id);
            Assert.Equal(added.Id, entity.Id);
            Assert.Equal(added, entity);
        }
    }
}
