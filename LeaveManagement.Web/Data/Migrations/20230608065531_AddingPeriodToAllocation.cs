using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "addc72e1-1de6-463b-a6b7-7adee86a255f",
                column: "ConcurrencyStamp",
                value: "f3fff455-2c1d-4565-8746-e523827c1f5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afdc72e1-1de6-463b-a6b7-7adee96a355f",
                column: "ConcurrencyStamp",
                value: "cdfe563c-e22b-4252-a02c-38074f234195");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addc72e1-2de4-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49267f77-9fe4-4f2e-a55d-310883f28149", "AQAAAAEAACcQAAAAEOLIDQvO1iOfJ9/GSR95rimYNxo19OapoQV4rVUUVyN0D9IZn5Gc+R5kYP4hA25q1A==", "ed0283c8-34e1-49c8-940f-de151ee8570d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeec82e1-1de6-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa42c13f-2807-49ad-aca9-806e14578b40", "AQAAAAEAACcQAAAAEBV569u9owR8oY6emXC/rxuM6ytIhU/FTjy4Txy+uWWG+QzwocIAeGYlcaQmHo+34A==", "b92b1494-371b-4e47-871c-b32c599ed988" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f936eb4a-5655-408f-ae8c-d38c8c05d8be", "AQAAAAEAACcQAAAAEJL44Xp9WHXu4vVoHKZVQlN5+dl7K8F2k6+yejXV7lRLRFEo+5WDG1GVhpMwqIx2Gw==", "bd54c2d3-3bfc-4c45-9c41-2526bad8cf4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeec82e1-1de6-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "183d56c4-2943-43ef-94b8-ab5ebb99d205", "AQAAAAEAACcQAAAAEHyy8mGGJDM++lKmZjYxxCvd0cJPyyD+AsDsMdVseVV2J911XhCnUWc0KdPXiQhi0g==", "2652adc8-aa0e-4b46-a7ef-116fc26b620f" });
        }
    }
}
