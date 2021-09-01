using MagazinHaine.Models;
using MagazinHaine.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Controllers
{
    public class ProdusController : Controller
    {
        private readonly IProdusRepository _produsRepository;
        private readonly ICategorieRepository _categorieRepository;

        public ProdusController(IProdusRepository produsRepository, ICategorieRepository categorieRepository)
        {
            _produsRepository = produsRepository;
            _categorieRepository = categorieRepository;
        }

        public ViewResult  List(string categorie)
        {
            IEnumerable<Produs> produse;
            IEnumerable<Categorie> categorii;
            if(string.IsNullOrEmpty(categorie))
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
        public ViewResult ListaBarbati(string categorie)
        {
            IEnumerable<Produs> produse;
            IEnumerable<Categorie> categorii;
            if (string.IsNullOrEmpty(categorie))
            {
                produse = _produsRepository.GetAllProduse.OrderBy(c => c.CategorieId);
                categorii = _categorieRepository.GetAllCategori.OrderBy(c => c.NumeCategorie);
            }
            else
            {

                produse = _produsRepository.GetAllProduse.Where(c => c.TipProdus == 1);
                categorii = _categorieRepository.GetAllCategori.Where(c => c.NumeCategorie == categorie);
            }
            return View(new ProdusListViewModel
            {
                Produse = produse,
                Categorii = categorii
            }) ;
        }
        public ViewResult ListaFemei(string categorie)
        {
            IEnumerable<Produs> produse;
            IEnumerable<Categorie> categorii;
            if (string.IsNullOrEmpty(categorie))
            {
                produse = _produsRepository.GetAllProduse.OrderBy(c => c.CategorieId);
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
        public ViewResult ListaCopii(string categorie)
        {
            IEnumerable<Produs> produse;
            IEnumerable<Categorie> categorii;
            if (string.IsNullOrEmpty(categorie))
            {
                ViewBag.categorie = categorie;
                produse = _produsRepository.GetAllProduse.OrderBy(c => c.CategorieId);
                categorii = _categorieRepository.GetAllCategori.OrderBy(c => c.CategorieId);
            }
            else
            {
                produse = _produsRepository.GetAllProduse.Where(c => c.CategorieId == 1 && c.TipProdus == 3 && Request.Path.ToString().Contains(c.Categorie.NumeCategorie));
                categorii = _categorieRepository.GetAllCategori.Where(c => c.NumeCategorie == categorie).OrderBy(c => c.NumeCategorie);
            }
            return View(new ProdusListViewModel
            {
                Produse = produse,
                Categorii = categorii
            });
            //IEnumerable<Produs> produse;
            //IEnumerable<Categorie> categorii;
            //produse = _produsRepository.GetAllProduse.Where(c => c.ProdusId == 1 && c.TipProdus == 3);
            //categorii = _categorieRepository.GetAllCategori.Where(c => c.NumeCategorie == categorie);
            //return View(new ProdusListViewModel
            //{
            //    Produse = produse,
            //    Categorii = categorii
            //});
        }
        [HttpGet]
        public ActionResult GetTricouri(int id)
        {
            return PartialView("_produsCard", new ProdusListViewModel { CategorieId = id });
        }
        public IActionResult TreiDeAnimation()
        {
            
            return View();
        }
        public IActionResult Detalii(int id)
        {
            var produs = _produsRepository.GetProdusDupaId(id);
            if (produs == null)
                return NotFound();
            return View(produs);
        }
    }
}
