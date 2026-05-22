using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_Management.Migrations
{
    /// <inheritdoc />
    public partial class c : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookProfileURL",
                table: "EmployeeSocialMedia");

            migrationBuilder.DropColumn(
                name: "InstagramHandleURL",
                table: "EmployeeSocialMedia");

            migrationBuilder.DropColumn(
                name: "LinkedInProfileURL",
                table: "EmployeeSocialMedia");

            migrationBuilder.DropColumn(
                name: "PortfolioURL",
                table: "EmployeeSocialMedia");

            migrationBuilder.DropColumn(
                name: "TwitterHandleURL",
                table: "EmployeeSocialMedia");

            migrationBuilder.DropColumn(
                name: "ActivityStatus",
                table: "EmployeeDitailse");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "EmployeeDitailse");

            migrationBuilder.DropColumn(
                name: "EmployeeStatus",
                table: "EmployeeDitailse");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacebookProfileURL",
                table: "EmployeeSocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InstagramHandleURL",
                table: "EmployeeSocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinkedInProfileURL",
                table: "EmployeeSocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PortfolioURL",
                table: "EmployeeSocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TwitterHandleURL",
                table: "EmployeeSocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ActivityStatus",
                table: "EmployeeDitailse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "EmployeeDitailse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeStatus",
                table: "EmployeeDitailse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
