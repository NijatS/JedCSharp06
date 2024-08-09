using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORM.Migrations
{
    /// <inheritdoc />
    public partial class updatedDoctorTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Hekimler",
                table: "Hekimler");

            migrationBuilder.RenameTable(
                name: "Hekimler",
                newName: "Doctors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Hekimler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hekimler",
                table: "Hekimler",
                column: "Id");
        }
    }
}
