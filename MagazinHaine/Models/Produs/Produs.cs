using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class Produs
    {
        public int ProdusId { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public decimal Pret { get; set; }
        public string  UrlPoza { get; set; }
        public string UrlThumbnailPoza { get; set; }
        public bool EsteDeVanzare { get; set; }
        public bool EsteInStoc { get; set; }
        public int CategorieId { get; set; }
        public int TipProdus { get; set; }
        public string Marime { get; set; }
        public Categorie Categorie { get; set; }
    }
}
