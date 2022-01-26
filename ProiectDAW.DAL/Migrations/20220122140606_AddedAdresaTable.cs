using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectDAW.DAL.Migrations
{
    public partial class AddedAdresaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clienti",
                newName: "ClientId");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clienti",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Clienti",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adrese",
                columns: table => new
                {
                    AdresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Strada = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Numar = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Oras = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Judet = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adrese", x => x.AdresaId);
                    table.ForeignKey(
                        name: "FK_Adrese_Clienti_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clienti",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adrese_ClientId",
                table: "Adrese",
                column: "ClientId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adrese");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clienti");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Clienti");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clienti",
                newName: "Id");
        }
    }
}
