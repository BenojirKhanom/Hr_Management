using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_Management.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeDtsNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmploymentDetails",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActivityStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    designationId = table.Column<int>(type: "int", nullable: true),
                    departmentId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmploymentDetails_Department_departmentId",
                        column: x => x.departmentId,
                        principalSchema: "Master",
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmploymentDetails_Designation_designationId",
                        column: x => x.designationId,
                        principalSchema: "Master",
                        principalTable: "Designation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmploymentDetails_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ParentsInformation",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FathersName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersNID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersPassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FathersMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersNID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersPassportNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MothersMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentsInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParentsInformation_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaInformation",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkedInUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GitHubUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    employeeId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMediaInformation_EmployeeInfo_employeeId",
                        column: x => x.employeeId,
                        principalSchema: "HR",
                        principalTable: "EmployeeInfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentDetails_departmentId",
                schema: "HR",
                table: "EmploymentDetails",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentDetails_designationId",
                schema: "HR",
                table: "EmploymentDetails",
                column: "designationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentDetails_employeeId",
                schema: "HR",
                table: "EmploymentDetails",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentsInformation_employeeId",
                schema: "HR",
                table: "ParentsInformation",
                column: "employeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediaInformation_employeeId",
                schema: "HR",
                table: "SocialMediaInformation",
                column: "employeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmploymentDetails",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "ParentsInformation",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "SocialMediaInformation",
                schema: "HR");
        }
    }
}
