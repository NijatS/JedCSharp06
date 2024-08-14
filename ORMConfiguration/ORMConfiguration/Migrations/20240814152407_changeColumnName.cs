using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMConfiguration.Migrations
{
    /// <inheritdoc />
    public partial class changeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Insanlar",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Insanlar",
                newName: "Ad");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Insanlar",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "Insanlar",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Insanlar",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Insanlar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");
        }
    }
}
