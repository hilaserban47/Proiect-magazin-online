using Microsoft.EntityFrameworkCore.Migrations;

namespace MagazinHaine.Migrations
{
    public partial class IncarcareDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorii",
                columns: new[] { "CategorieId", "DescriereCategorie", "NumeCategorie" },
                values: new object[,]
                {
                    { 1, null, "Tricouri" },
                    { 2, null, "Bluze" },
                    { 3, null, "Geci" },
                    { 4, null, "Pantaloni" },
                    { 5, null, "Adidasi" }
                });

            migrationBuilder.InsertData(
                table: "Produse",
                columns: new[] { "ProdusId", "CategorieId", "Descriere", "EsteDeVanzare", "EsteInStoc", "Nume", "Pret", "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { 1, 1, "Foarte placut la purtare", false, true, "Tricou bumbac", 25m, "~\\img\\tricou.jpg", "~\\img\\Thumbnail\\tricou-small.jpg" });

            migrationBuilder.InsertData(
                table: "Produse",
                columns: new[] { "ProdusId", "CategorieId", "Descriere", "EsteDeVanzare", "EsteInStoc", "Nume", "Pret", "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { 2, 1, "Foarte placut la purtare", false, true, "Tricou bumbac", 25m, "~\\img\\bluza.jpg", "~\\img\\Thumbnail\\bluza-small.jpg" });

            migrationBuilder.InsertData(
                table: "Produse",
                columns: new[] { "ProdusId", "CategorieId", "Descriere", "EsteDeVanzare", "EsteInStoc", "Nume", "Pret", "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { 3, 1, "Foarte placut la purtare", false, true, "Tricou bumbac", 25m, "~\\img\\geaca.jpg", "~\\img\\Thumbnail\\geaca-small.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorii",
                keyColumn: "CategorieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorii",
                keyColumn: "CategorieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorii",
                keyColumn: "CategorieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorii",
                keyColumn: "CategorieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorii",
                keyColumn: "CategorieId",
                keyValue: 1);
        }
    }
}
