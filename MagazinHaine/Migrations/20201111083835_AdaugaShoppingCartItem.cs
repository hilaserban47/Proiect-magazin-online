using Microsoft.EntityFrameworkCore.Migrations;

namespace MagazinHaine.Migrations
{
    public partial class AdaugaShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    ProdusId = table.Column<int>(nullable: true),
                    Cantitate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Produse_ProdusId",
                        column: x => x.ProdusId,
                        principalTable: "Produse",
                        principalColumn: "ProdusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 1,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "\\img\\tricou.jpg", "\\img\\thumbnails\\tricou-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 2,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "\\img\\bluza.jpg", "\\img\\thumbnails\\bluza-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 3,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "\\img\\geaca.jpg", "\\img\\thumbnails\\geaca-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 4,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "\\img\\thumbnails\\pantaloni-small.jpg", "\\img\\thumbnails\\pantaloni-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 5,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "\\img\\thumbnails\\adidasi-small.jpg", "\\img\\thumbnails\\adidasi-small.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProdusId",
                table: "ShoppingCartItems",
                column: "ProdusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 1,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "~\\img\\tricou.jpg", "~\\img\\thumbnails\\tricou-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 2,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "~\\img\\bluza.jpg", "~\\img\\thumbnails\\bluza-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 3,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "~\\img\\geaca.jpg", "~\\img\\thumbnails\\geaca-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 4,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "~\\img\\thumbnails\\pantaloni-small.jpg", "~\\img\\thumbnails\\pantaloni-small.jpg" });

            migrationBuilder.UpdateData(
                table: "Produse",
                keyColumn: "ProdusId",
                keyValue: 5,
                columns: new[] { "UrlPoza", "UrlThumbnailPoza" },
                values: new object[] { "~\\img\\thumbnails\\adidasi-small.jpg", "~\\img\\thumbnails\\adidasi-small.jpg" });
        }
    }
}
