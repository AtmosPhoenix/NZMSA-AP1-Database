using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSIMS.Migrations
{
    public partial class CreateNewAddrController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Student_Student",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_Student",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Student",
                table: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Student",
                table: "Address",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_Student",
                table: "Address",
                column: "Student");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Student_Student",
                table: "Address",
                column: "Student",
                principalTable: "Student",
                principalColumn: "studentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
