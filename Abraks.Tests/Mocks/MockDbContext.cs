namespace Abraks.Tests.Mocks
{
    using System;
    using Data;
    using Microsoft.EntityFrameworkCore;

    public static class MockDbContext
    {
        public static AbraksContext GetContext()
        {
            var options = new DbContextOptionsBuilder<AbraksContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new AbraksContext(options);
        }
    }
}
