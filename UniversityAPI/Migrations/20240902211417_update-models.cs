using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatemodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "telephone",
                table: "Studants",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Studants",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Studants",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Studants",
                newName: "telephone");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Studants",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Studants",
                newName: "email");
        }
    }
}
