using Microsoft.EntityFrameworkCore.Migrations;

namespace MagazinHaine.Migrations
{
    public partial class IncarcareDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 1,
                column: "UrlThumbnailPoza",
                value: "\\img\\thumbnails\\tricou-small.jpg");

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 2,
                columns: new[] { "CategorieId", "Descriere", "Nume", "Pret", "UrlThumbnailPoza" },
                values: new object[] { 2, "Tine foarte multa caldura", "Bluza pentru sezonul rece", 100m, "\\img\\thumbnails\\bluza-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 3,
                columns: new[] { "CategorieId", "Descriere", "Nume", "Pret", "UrlThumbnailPoza" },
                values: new object[] { 3, "Facuta din pene de gasca", "Geaca de puf", 125m, "\\img\\thumbnails\\geaca-small.jpg" });

            migrationBuilder.InsertData(
                table: "Produse",
                columns: new[] { "ProdusId", "CategorieId", "Descriere", "EsteDeVanzare", "EsteInStoc", "Nume", "Pret", "UrlPoza", "UrlThumbnailPoza" },
                values: new object[,]
                {
                    { 4, 4, "Material foarte fin", false, true, "Pantaloni de dama", 75m, "\\img\\thumbnails\\pantaloni-small.jpg", "\\img\\thumbnails\\pantaloni-small.jpg" },
                    { 5, 5, "Talpa foarte moale, placuti la purtare.", false, true, "Adidasi Fila", 75m, "\\img\\thumbnails\\adidasi-small.jpg", "\\img\\thumbnails\\adidasi-small.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 1,
                column: "UrlThumbnailPoza",
                value: "\\img\\Thumbnail\\tricou-small.jpg");

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 2,
                columns: new[] { "CategorieId", "Descriere", "Nume", "Pret", "UrlThumbnailPoza" },
                values: new object[] { 1, "Foarte placut la purtare", "Tricou bumbac", 25m, "\\img\\Thumbnail\\bluza-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 3,
                columns: new[] { "CategorieId", "Descriere", "Nume", "Pret", "UrlThumbnailPoza" },
                values: new object[] { 1, "Foarte placut la purtare", "Tricou bumbac", 25m, "\\img\\Thumbnail\\geaca-small.jpg" });
        }
    }
}
