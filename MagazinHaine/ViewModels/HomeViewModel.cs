using MagazinHaine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Produs> ProdusLaReducere { get; set; }
        public IEnumerable<Categorie> Categorii { get; set; }
    }
}
