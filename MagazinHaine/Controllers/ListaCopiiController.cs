using MagazinHaine.Models;
using MagazinHaine.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Controllers
{
    public class ListaCopiiController : Controller
    {
        private readonly IProdusRepository _produsRepository;
        private readonly ICategorieRepository _categorieRepository;

        public ListaCopiiController(IProdusRepository produsRepository, ICategorieRepository categorieRepository)
        {
            _produsRepository = produsRepository;
            _categorieRepository = categorieRepository;
        }

        public ViewResult ListaCopii(string categorie)
        {
            IEnumerable<Produs> produse;
            IEnumerable<Categorie> categorii;
            if (string.IsNullOrEmpty(categorie))
            {
                produse = _produsRepository.GetAllProduse.OrderBy(c => c.ProdusId);
                categorii = _categorieRepository.GetAllCategori.OrderBy(c => c.CategorieId);
            }
            else
            {
                produse = _produsRepository.GetAllProduse.Where(c => c.Categorie.NumeCategorie == categorie);
                categorii = _categorieRepository.GetAllCategori.Where(c => c.NumeCategorie == categorie);
            }
            return View(new ProdusListViewModel
            {
                Produse = produse,
                Categorii = categorii
            });
        }
        public IActionResult GetTricouri()
        {
            IEnumerable<Produs> produse;
            produse = _produsRepository.GetAllProduse.Where(c => c.ProdusId == 1 && c.TipProdus == 3);
            return View(produse);
        }
        public ViewResult TricouCopii(int categorieId)
        {
            IEnumerable<Categorie> categorii;
            IEnumerable<Produs> produse;
            categorii = _categorieRepository.GetAllCategori.Where(c => c.CategorieId == 1);
            produse = _produsRepository.GetAllProduse.Where(c => c.TipProdus == 1);
            return View(new ProdusListViewModel
            {
                Produse = produse,
                Categorii = categorii
            });
        }

    }
}
