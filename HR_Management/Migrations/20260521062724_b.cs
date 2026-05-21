using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_Management.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSocialMedias",
                table: "EmployeeSocialMedias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee_Ditailses",
                table: "Employee_Ditailses");

            migrationBuilder.RenameTable(
                name: "EmployeeSocialMedias",
                newName: "EmployeeSocialMedia");

            migrationBuilder.RenameTable(
                name: "Employee_Ditailses",
                newName: "Employee_Ditailse");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSocialMedia",
                table: "EmployeeSocialMedia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee_Ditailse",
                table: "Employee_Ditailse",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSocialMedia",
                table: "EmployeeSocialMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee_Ditailse",
                table: "Employee_Ditailse");

            migrationBuilder.RenameTable(
                name: "EmployeeSocialMedia",
                newName: "EmployeeSocialMedias");

            migrationBuilder.RenameTable(
                name: "Employee_Ditailse",
                newName: "Employee_Ditailses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSocialMedias",
                table: "EmployeeSocialMedias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee_Ditailses",
                table: "Employee_Ditailses",
                column: "Id");
        }
    }
}
