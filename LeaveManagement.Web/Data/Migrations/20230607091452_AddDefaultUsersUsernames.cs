using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "addc72e1-1de6-463b-a6b7-7adee86a255f",
                column: "ConcurrencyStamp",
                value: "fc5aebdd-7786-4749-8924-0798b35be01a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afdc72e1-1de6-463b-a6b7-7adee96a355f",
                column: "ConcurrencyStamp",
                value: "30aa3310-ada5-4dfc-be9c-46e29304b459");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addc72e1-2de4-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f936eb4a-5655-408f-ae8c-d38c8c05d8be", true, "LOCAL@LOCAL.COM", "AQAAAAEAACcQAAAAEJL44Xp9WHXu4vVoHKZVQlN5+dl7K8F2k6+yejXV7lRLRFEo+5WDG1GVhpMwqIx2Gw==", "bd54c2d3-3bfc-4c45-9c41-2526bad8cf4b", "local@local.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeec82e1-1de6-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "183d56c4-2943-43ef-94b8-ab5ebb99d205", true, "TEST@TEST.COM", "AQAAAAEAACcQAAAAEHyy8mGGJDM++lKmZjYxxCvd0cJPyyD+AsDsMdVseVV2J911XhCnUWc0KdPXiQhi0g==", "2652adc8-aa0e-4b46-a7ef-116fc26b620f", "test@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "addc72e1-1de6-463b-a6b7-7adee86a255f",
                column: "ConcurrencyStamp",
                value: "00cf73fe-de13-4c28-8178-f4a87bd1e3b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afdc72e1-1de6-463b-a6b7-7adee96a355f",
                column: "ConcurrencyStamp",
                value: "fd4504e8-b6a2-4254-850b-b4ff460c59d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addc72e1-2de4-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "227bbaef-e350-43b4-9e07-44d3a68cadb6", false, null, "AQAAAAEAACcQAAAAEOkGU/wY9wNOpjhP1wGXDTvNBQ+KZWGCoYvPKF7JzvvRXquS3dGzVfe0XsYF58AITQ==", "ff78eb28-281d-418e-9a26-bd8b91adbea8", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeec82e1-1de6-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9511ac9b-a7c9-400a-95e8-60e87a2e6349", false, null, "AQAAAAEAACcQAAAAEAJIdt8u8KL9Z0LXG2Sce+0U5Fj0xmxnVFVwCfftfAxiHgGzKUIE16N7bNwjMkAP0w==", "0076e569-0357-4e32-b8f2-fe37d630f260", null });
        }
    }
}
