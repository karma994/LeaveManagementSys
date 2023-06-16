using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "aeec82e1-1de6-463b-a6b7-7adee86a255f",
                    Email = "test@test.com",
                    NormalizedEmail = "TEST@TEST.COM",
                    NormalizedUserName = "TEST@TEST.COM",
                    UserName = "test@test.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "addc72e1-2de4-463b-a6b7-7adee86a255f",
                     Email = "local@local.com",
                     NormalizedEmail = "LOCAL@LOCAL.COM",
                     NormalizedUserName = "LOCAL@LOCAL.COM",
                     UserName = "local@local.com",
                     FirstName = "System",
                     LastName = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }
                );
        }
    }
}