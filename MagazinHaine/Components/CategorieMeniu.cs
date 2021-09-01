using MagazinHaine.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Components
{
    public class CategorieMeniu : ViewComponent
    {
        private readonly ICategorieRepository _categorieRepository;
        public CategorieMeniu(ICategorieRepository categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categorii = _categorieRepository.GetAllCategori.OrderBy(c => c.NumeCategorie);
            return View(categorii);
        }
    }
}
