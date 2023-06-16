using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   RoleId = "addc72e1-1de6-463b-a6b7-7adee86a255f",
                   UserId = "aeec82e1-1de6-463b-a6b7-7adee86a255f",                    
               },
               new IdentityUserRole<string>
               {
                   RoleId = "afdc72e1-1de6-463b-a6b7-7adee96a355f",
                   UserId = "addc72e1-2de4-463b-a6b7-7adee86a255f",
               }
               );
        }
    }
}