using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class LeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveId",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_LeaveId",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "LeaveId",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "addc72e1-1de6-463b-a6b7-7adee86a255f",
                column: "ConcurrencyStamp",
                value: "7724148b-382f-4a5a-ad0b-59e80ebdcb9e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afdc72e1-1de6-463b-a6b7-7adee96a355f",
                column: "ConcurrencyStamp",
                value: "f2eef282-ee72-4f88-bee5-9bdabc8842dd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "addc72e1-2de4-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b6b9ddb-537f-48ec-aca8-106c0b1a1b50", "AQAAAAEAACcQAAAAEN21XCaVm5LhpEWUzPErVQS0TqgAOc+Ha9kfWgWl3YnrgyCM6A03ku0a6hB36L83pg==", "c822ad5b-5e26-4fdb-8ff8-2dbaf3bddff8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeec82e1-1de6-463b-a6b7-7adee86a255f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bbc7045-c03a-40d5-a278-47a3783ae9d7", "AQAAAAEAACcQAAAAEBdH1wvePHL1pH/E8f/167UeuexzCiZIz2Xocv5/24qj0VdkBT9dMfEerGxWdjfEXQ==", "f6520879-f586-4b2f-ab51-9c0a43252197" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.AddColumn<int>(
                name: "LeaveId",
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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_LeaveId",
                table: "LeaveAllocations",
                column: "LeaveId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveId",
                table: "LeaveAllocations",
                column: "LeaveId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
