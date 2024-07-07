using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSIMSDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingStudentTableToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentMaster",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherMobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FatherDesig = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MotherMobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StudentClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentSection = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StudentDob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentDoj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentSchoolLeavingYear = table.Column<int>(type: "int", nullable: false),
                    StudentAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StudentReligion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentCast = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentGender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StudentNationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StudentHouse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentAdharNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StudentPenNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMaster", x => x.StudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentMaster");
        }
    }
}
