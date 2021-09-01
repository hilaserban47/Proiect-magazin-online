using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Categorie> Categorii { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
        public DbSet<DetaliuComanda> DetaliiComanda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Categorie>().HasData(new Categorie { CategorieId = 1, NumeCategorie = "Tricouri" });
            modelBuilder.Entity<Categorie>().HasData(new Categorie { CategorieId = 2, NumeCategorie = "Bluze" });
            modelBuilder.Entity<Categorie>().HasData(new Categorie { CategorieId = 3, NumeCategorie = "Geci" });
            modelBuilder.Entity<Categorie>().HasData(new Categorie { CategorieId = 4, NumeCategorie = "Pantaloni" });
            modelBuilder.Entity<Categorie>().HasData(new Categorie { CategorieId = 5, NumeCategorie = "Adidasi" });

            modelBuilder.Entity<Produs>().HasData(new Produs
            {
                ProdusId = 1,
                Nume = "Tricou bumbac",
                Pret = 25M,
                Descriere = "Foarte placut la purtare",
                CategorieId = 1,
                UrlPoza = "\\img\\tricou.jpg",
                UrlThumbnailPoza = "\\img\\thumbnails\\tricou-small.jpg",
                EsteInStoc = true,
                EsteDeVanzare = false
            });
            modelBuilder.Entity<Produs>().HasData(new Produs
            {
                ProdusId = 2,
                Nume = "Bluza pentru sezonul rece",
                Pret = 100M,
                Descriere = "Tine foarte multa caldura",
                CategorieId = 2,
                UrlPoza = "\\img\\bluza.jpg",
                UrlThumbnailPoza = "\\img\\thumbnails\\bluza-small.jpg",
                EsteInStoc = true,
                EsteDeVanzare = false
            });
            modelBuilder.Entity<Produs>().HasData(new Produs
            {
                ProdusId = 3,
                Nume = "Geaca de puf",
                Pret = 125M,
                Descriere = "Facuta din pene de gasca",
                CategorieId = 3,
                UrlPoza = "\\img\\geaca.jpg",
                UrlThumbnailPoza = "\\img\\thumbnails\\geaca-small.jpg",
                EsteInStoc = true,
                EsteDeVanzare = false
            });
            modelBuilder.Entity<Produs>().HasData(new Produs
            {
                ProdusId = 4,
                Nume = "Pantaloni de dama",
                Pret = 75M,
                Descriere = "Material foarte fin",
                CategorieId = 4,
                UrlPoza = "\\img\\thumbnails\\pantaloni-small.jpg",
                UrlThumbnailPoza = "\\img\\thumbnails\\pantaloni-small.jpg",
                EsteInStoc = true,
                EsteDeVanzare = false
            });
            modelBuilder.Entity<Produs>().HasData(new Produs
            {
                ProdusId = 5,
                Nume = "Adidasi Fila",
                Pret = 75M,
                Descriere = "Talpa foarte moale, placuti la purtare.",
                CategorieId = 5,
                UrlPoza = "\\img\\thumbnails\\adidasi-small.jpg",
                UrlThumbnailPoza = "\\img\\thumbnails\\adidasi-small.jpg",
                EsteInStoc = true,
                EsteDeVanzare = false
            });
        }
    }
}
