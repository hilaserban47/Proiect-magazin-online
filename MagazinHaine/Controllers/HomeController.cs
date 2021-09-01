using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using MagazinHaine.Models;
using MagazinHaine.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MagazinHaine.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdusRepository _produsRepository;
        public HomeController(IProdusRepository produsRepository)
        {
            _produsRepository = produsRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                
                ProdusLaReducere = _produsRepository.GetProdusDeVanzare
            };
            return View(homeViewModel);
        }
    }
}
