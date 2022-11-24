using Microsoft.EntityFrameworkCore.Migrations;

namespace LMS_WEB_API.Migrations
{
    public partial class onetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeesEmployeeId",
                table: "ApplyLeave",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplyLeave_EmployeesEmployeeId",
                table: "ApplyLeave",
                column: "EmployeesEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplyLeave_Employees_EmployeesEmployeeId",
                table: "ApplyLeave",
                column: "EmployeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplyLeave_Employees_EmployeesEmployeeId",
                table: "ApplyLeave");

            migrationBuilder.DropIndex(
                name: "IX_ApplyLeave_EmployeesEmployeeId",
                table: "ApplyLeave");

            migrationBuilder.DropColumn(
                name: "EmployeesEmployeeId",
                table: "ApplyLeave");
        }
    }
}
