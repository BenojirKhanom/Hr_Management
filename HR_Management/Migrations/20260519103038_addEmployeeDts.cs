using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_Management.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeDts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employeeInfos",
                table: "employeeInfos");

            migrationBuilder.EnsureSchema(
                name: "Master");

            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.RenameTable(
                name: "employeeInfos",
                newName: "EmployeeInfo",
                newSchema: "HR");

            migrationBuilder.AddColumn<string>(
                name: "BirthIdentificationNo",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                schema: "HR",
                table: "EmployeeInfo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalId",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportNo",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TINNo",
                schema: "HR",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "bloodGroupId",
                schema: "HR",
                table: "EmployeeInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                schema: "HR",
                table: "EmployeeInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "designationId",
                schema: "HR",
                table: "EmployeeInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "religionId",
                schema: "HR",
                table: "EmployeeInfo",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeInfo",
                schema: "HR",
                table: "EmployeeInfo",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BloodGroup",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designation",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesignationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                schema: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_bloodGroupId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "bloodGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_departmentId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_designationId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "designationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInfo_religionId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "religionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfo_BloodGroup_bloodGroupId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "bloodGroupId",
                principalSchema: "Master",
                principalTable: "BloodGroup",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfo_Department_departmentId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "departmentId",
                principalSchema: "Master",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfo_Designation_designationId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "designationId",
                principalSchema: "Master",
                principalTable: "Designation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInfo_Religion_religionId",
                schema: "HR",
                table: "EmployeeInfo",
                column: "religionId",
                principalSchema: "Master",
                principalTable: "Religion",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfo_BloodGroup_bloodGroupId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfo_Department_departmentId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfo_Designation_designationId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeInfo_Religion_religionId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropTable(
                name: "BloodGroup",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Designation",
                schema: "Master");

            migrationBuilder.DropTable(
                name: "Religion",
                schema: "Master");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeInfo",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInfo_bloodGroupId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInfo_departmentId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInfo_designationId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeInfo_religionId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "BirthIdentificationNo",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "Gender",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "NationalId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "Nationality",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "PassportNo",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "TINNo",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "bloodGroupId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "departmentId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "designationId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "religionId",
                schema: "HR",
                table: "EmployeeInfo");

            migrationBuilder.RenameTable(
                name: "EmployeeInfo",
                schema: "HR",
                newName: "employeeInfos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employeeInfos",
                table: "employeeInfos",
                column: "Id");
        }
    }
}
