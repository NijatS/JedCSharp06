using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORMConfiguration.Migrations
{
    /// <inheritdoc />
    public partial class addedWorkTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsYerininNomresi",
                table: "Insanlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insanlar_IsYerininNomresi",
                table: "Insanlar",
                column: "IsYerininNomresi");

            migrationBuilder.AddForeignKey(
                name: "FK_Insanlar_Works_IsYerininNomresi",
                table: "Insanlar",
                column: "IsYerininNomresi",
                principalTable: "Works",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insanlar_Works_IsYerininNomresi",
                table: "Insanlar");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropIndex(
                name: "IX_Insanlar_IsYerininNomresi",
                table: "Insanlar");

            migrationBuilder.DropColumn(
                name: "IsYerininNomresi",
                table: "Insanlar");
        }
    }
}
