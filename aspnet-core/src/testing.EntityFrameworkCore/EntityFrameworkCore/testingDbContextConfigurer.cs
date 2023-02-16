using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace testing.EntityFrameworkCore
{
    public static class testingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<testingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<testingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
