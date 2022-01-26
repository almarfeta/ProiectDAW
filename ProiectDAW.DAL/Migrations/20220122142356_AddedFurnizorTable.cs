using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectDAW.DAL.Migrations
{
    public partial class AddedFurnizorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Furnizori",
                columns: table => new
                {
                    FurnizorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Furnizori", x => x.FurnizorId);
                });

            migrationBuilder.CreateTable(
                name: "Produse",
                columns: table => new
                {
                    ProdusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Pret = table.Column<float>(type: "real", nullable: false),
                    FurnizorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produse", x => x.ProdusId);
                    table.ForeignKey(
                        name: "FK_Produse_Furnizori_FurnizorId",
                        column: x => x.FurnizorId,
                        principalTable: "Furnizori",
                        principalColumn: "FurnizorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produse_FurnizorId",
                table: "Produse",
                column: "FurnizorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produse");

            migrationBuilder.DropTable(
                name: "Furnizori");
        }
    }
}
