using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string NumeCategorie { get; set; }
        public string DescriereCategorie { get; set; }
        public string Icon { get; set; }
        public List<Produs> Produse { get; set; }
    }
}
