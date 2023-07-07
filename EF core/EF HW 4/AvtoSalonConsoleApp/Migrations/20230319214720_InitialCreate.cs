using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvtoSalonConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avtosalons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avtosalons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avtoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvtosalonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avtoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avtoes_Avtosalons_AvtosalonId",
                        column: x => x.AvtosalonId,
                        principalTable: "Avtosalons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avtoes_AvtosalonId",
                table: "Avtoes",
                column: "AvtosalonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avtoes");

            migrationBuilder.DropTable(
                name: "Avtosalons");
        }
    }
}
