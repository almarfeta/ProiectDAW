using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectDAW.DAL.Migrations
{
    public partial class AddedCosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cosuri",
                columns: table => new
                {
                    CosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    ProdusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cosuri", x => x.CosId);
                    table.ForeignKey(
                        name: "FK_Cosuri_Clienti_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clienti",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cosuri_Produse_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produse",
                        principalColumn: "ProdusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cosuri_ClientId",
                table: "Cosuri",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Cosuri_ProdusId",
                table: "Cosuri",
                column: "ProdusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cosuri");
        }
    }
}
