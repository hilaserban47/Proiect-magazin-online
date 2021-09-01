using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MagazinHaine.Migrations
{
    public partial class AdaugaAtribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comenzi",
                columns: table => new
                {
                    ComandaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeFamilie = table.Column<string>(maxLength: 30, nullable: false),
                    Prenume = table.Column<string>(maxLength: 45, nullable: false),
                    Adresa = table.Column<string>(maxLength: 100, nullable: false),
                    Oras = table.Column<string>(nullable: false),
                    CodPostal = table.Column<string>(maxLength: 6, nullable: false),
                    NumarTelefon = table.Column<string>(nullable: false),
                    TotalComanda = table.Column<decimal>(nullable: false),
                    ComandaPlasata = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comenzi", x => x.ComandaId);
                });

            migrationBuilder.CreateTable(
                name: "DetaliiComanda",
                columns: table => new
                {
                    DetaliuComandaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComandaId = table.Column<int>(nullable: false),
                    ProdusId = table.Column<int>(nullable: false),
                    Cantitate = table.Column<int>(nullable: false),
                    Pret = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetaliiComanda", x => x.DetaliuComandaId);
                    table.ForeignKey(
                        name: "FK_DetaliiComanda_Comenzi_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comenzi",
                        principalColumn: "ComandaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetaliiComanda_Produse_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produse",
                        principalColumn: "ProdusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetaliiComanda_ComandaId",
                table: "DetaliiComanda",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_DetaliiComanda_ProdusId",
                table: "DetaliiComanda",
                column: "ProdusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetaliiComanda");

            migrationBuilder.DropTable(
                name: "Comenzi");
        }
    }
}
