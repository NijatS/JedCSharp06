using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMConfiguration.Migrations
{
    /// <inheritdoc />
    public partial class updatedCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsNew",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "EngineNumber",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            // migrationBuilder.AlterColumn<string>(
            //     name: "VinCode",
            //     table: "Cars",
            //     type: "nvarchar(14)",
            //     maxLength: 14,
            //     nullable: false,
            //     oldClrType: typeof(string),
            //     oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EngineNumber",
                table: "Cars",
                column: "EngineNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Cars_EngineNumber",
                table: "Cars");

            migrationBuilder.AlterColumn<bool>(
                name: "IsNew",
                table: "Cars",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "EngineNumber",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "VinCode",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(14)",
                oldMaxLength: 14);
        }
    }
}
