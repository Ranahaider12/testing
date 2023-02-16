using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using testing.Authorization.Roles;
using testing.Authorization.Users;
using testing.MultiTenancy;

namespace testing.EntityFrameworkCore
{
    public class testingDbContext : AbpZeroDbContext<Tenant, Role, User, testingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public testingDbContext(DbContextOptions<testingDbContext> options)
            : base(options)
        {
        }
    }
}
