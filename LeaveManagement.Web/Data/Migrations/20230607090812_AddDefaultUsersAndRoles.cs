using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "addc72e1-1de6-463b-a6b7-7adee86a255f", "00cf73fe-de13-4c28-8178-f4a87bd1e3b0", "Administrator", "ADMINISTRATOR" },
                    { "afdc72e1-1de6-463b-a6b7-7adee96a355f", "fd4504e8-b6a2-4254-850b-b4ff460c59d7", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "addc72e1-2de4-463b-a6b7-7adee86a255f", 0, "227bbaef-e350-43b4-9e07-44d3a68cadb6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "local@local.com", false, "System", "User", false, null, "LOCAL@LOCAL.COM", null, "AQAAAAEAACcQAAAAEOkGU/wY9wNOpjhP1wGXDTvNBQ+KZWGCoYvPKF7JzvvRXquS3dGzVfe0XsYF58AITQ==", null, false, "ff78eb28-281d-418e-9a26-bd8b91adbea8", null, false, null },
                    { "aeec82e1-1de6-463b-a6b7-7adee86a255f", 0, "9511ac9b-a7c9-400a-95e8-60e87a2e6349", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", false, "System", "Admin", false, null, "TEST@TEST.COM", null, "AQAAAAEAACcQAAAAEAJIdt8u8KL9Z0LXG2Sce+0U5Fj0xmxnVFVwCfftfAxiHgGzKUIE16N7bNwjMkAP0w==", null, false, "0076e569-0357-4e32-b8f2-fe37d630f260", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "afdc72e1-1de6-463b-a6b7-7adee96a355f", "addc72e1-2de4-463b-a6b7-7adee86a255f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "addc72e1-1de6-463b-a6b7-7adee86a255f", "aeec82e1-1de6-463b-a6b7-7adee86a255f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "afdc72e1-1de6-463b-a6b7-7adee96a355f", "addc72e1-2de4-463b-a6b7-7adee86a255f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "addc72e1-1de6-463b-a6b7-7adee86a255f", "aeec82e1-1de6-463b-a6b7-7adee86a255f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "addc72e1-1de6-463b-a6b7-7adee86a255f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afdc72e1-1de6-463b-a6b7-7adee96a355f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addc72e1-2de4-463b-a6b7-7adee86a255f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeec82e1-1de6-463b-a6b7-7adee86a255f");
        }
    }
}
