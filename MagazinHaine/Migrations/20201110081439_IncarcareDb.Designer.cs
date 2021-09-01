﻿// <auto-generated />
using MagazinHaine.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MagazinHaine.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201110081439_IncarcareDb")]
    partial class IncarcareDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MagazinHaine.Models.Categorie", b =>
                {
                    b.Property<int>("CategorieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriereCategorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeCategorie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategorieId");

                    b.ToTable("Categorii");

                    b.HasData(
                        new
                        {
                            CategorieId = 1,
                            NumeCategorie = "Tricouri"
                        },
                        new
                        {
                            CategorieId = 2,
                            NumeCategorie = "Bluze"
                        },
                        new
                        {
                            CategorieId = 3,
                            NumeCategorie = "Geci"
                        },
                        new
                        {
                            CategorieId = 4,
                            NumeCategorie = "Pantaloni"
                        },
                        new
                        {
                            CategorieId = 5,
                            NumeCategorie = "Adidasi"
                        });
                });

            modelBuilder.Entity("MagazinHaine.Models.Produs", b =>
                {
                    b.Property<int>("ProdusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorieId")
                        .HasColumnType("int");

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EsteDeVanzare")
                        .HasColumnType("bit");

                    b.Property<bool>("EsteInStoc")
                        .HasColumnType("bit");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrlPoza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlThumbnailPoza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdusId");

                    b.HasIndex("CategorieId");

                    b.ToTable("Produse");

                    b.HasData(
                        new
                        {
                            ProdusId = 1,
                            CategorieId = 1,
                            Descriere = "Foarte placut la purtare",
                            EsteDeVanzare = false,
                            EsteInStoc = true,
                            Nume = "Tricou bumbac",
                            Pret = 25m,
                            UrlPoza = "~\\img\\tricou.jpg",
                            UrlThumbnailPoza = "~\\img\\Thumbnail\\tricou-small.jpg"
                        },
                        new
                        {
                            ProdusId = 2,
                            CategorieId = 1,
                            Descriere = "Foarte placut la purtare",
                            EsteDeVanzare = false,
                            EsteInStoc = true,
                            Nume = "Tricou bumbac",
                            Pret = 25m,
                            UrlPoza = "~\\img\\bluza.jpg",
                            UrlThumbnailPoza = "~\\img\\Thumbnail\\bluza-small.jpg"
                        },
                        new
                        {
                            ProdusId = 3,
                            CategorieId = 1,
                            Descriere = "Foarte placut la purtare",
                            EsteDeVanzare = false,
                            EsteInStoc = true,
                            Nume = "Tricou bumbac",
                            Pret = 25m,
                            UrlPoza = "~\\img\\geaca.jpg",
                            UrlThumbnailPoza = "~\\img\\Thumbnail\\geaca-small.jpg"
                        });
                });

            modelBuilder.Entity("MagazinHaine.Models.Produs", b =>
                {
                    b.HasOne("MagazinHaine.Models.Categorie", "Categorie")
                        .WithMany("Produse")
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
