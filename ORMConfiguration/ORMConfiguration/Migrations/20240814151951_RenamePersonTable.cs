using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMConfiguration.Migrations
{
    /// <inheritdoc />
    public partial class RenamePersonTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Insanlar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Insanlar",
                table: "Insanlar",
                column: "FinCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Insanlar",
                table: "Insanlar");

            migrationBuilder.RenameTable(
                name: "Insanlar",
                newName: "Persons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "FinCode");
        }
    }
}
