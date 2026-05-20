using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_Management.Migrations
{
    /// <inheritdoc />
    public partial class Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_Ditailses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityStatus = table.Column<bool>(type: "bit", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Ditailses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkedInProfileURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacebookProfileURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterHandleURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramHandleURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GitHubProfileURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortfolioURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSocialMedias", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Ditailses");

            migrationBuilder.DropTable(
                name: "EmployeeSocialMedias");
        }
    }
}
