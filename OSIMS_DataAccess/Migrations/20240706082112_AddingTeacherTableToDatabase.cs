using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OSIMSDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingTeacherTableToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeacherMaster",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeacherDesig = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeacherDob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false),
                    TeacherReligion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeacherFatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeacherMotherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeacherWifeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeacherSubject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeacherQualification = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeacherAdhar = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TeacherPanNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TeacherMobileNo1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TeacherMobileNo2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TeacherEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TeacherAddress1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TeacherAddress2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TeacherGender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TeacherDoj = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeacherDoLeaving = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeacherClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TeacherNoofChildren = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherMaster", x => x.TeacherId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherMaster");
        }
    }
}
