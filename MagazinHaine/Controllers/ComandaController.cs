using MagazinHaine.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Controllers
{
    [Authorize]
    public class ComandaController : Controller
    {
        private readonly IComandaRepository _comandaRepository;
        private readonly ShoppingCart _shoppingCart;
        public ComandaController(IComandaRepository comandaRepository , ShoppingCart shoppingCart)
        {
            _comandaRepository = comandaRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Verifica()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Verifica(Comanda comanda)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            if(_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "ShoppingCart e gol");
            }
            if(ModelState.IsValid)
            {
                _comandaRepository.CreazaComanda(comanda);
                _shoppingCart.CurataCart();
                return RedirectToAction("VerificareCompleta");   
            }
            return View(comanda);
        }
        public IActionResult VerificareCompleta()
        {
            ViewBag.VerificareCompletaMesaj = "Multumim pentru comanda. Sa va bucurati de produs";
            return View();

        }
    }
}
