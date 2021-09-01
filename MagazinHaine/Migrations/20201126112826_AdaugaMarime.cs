using Microsoft.EntityFrameworkCore.Migrations;

namespace MagazinHaine.Migrations
{
    public partial class AdaugaMarime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Marime",
                table: "Produse",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marime",
                table: "Produse");
        }
    }
}
