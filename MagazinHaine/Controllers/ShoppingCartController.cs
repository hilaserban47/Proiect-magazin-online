using MagazinHaine.Models;
using MagazinHaine.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProdusRepository _produsRepository;

        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProdusRepository produsRepository , ShoppingCart shoppingCart)
        {
            _produsRepository = produsRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AdaugaInShoppingCart(int produsId)
        {
            var produsSelectat = _produsRepository.GetAllProduse.FirstOrDefault(c => c.ProdusId == produsId);

            if(produsSelectat != null)
            {
                _shoppingCart.AdaugaInCos(produsSelectat, 1);
            }

            return RedirectToAction("Index");
        }
        public RedirectToActionResult StergeDinShoppingCart(int produsId)
        {
            var produsSelectat = _produsRepository.GetAllProduse.FirstOrDefault(c => c.ProdusId == produsId);
            if(produsSelectat != null)
            {
                _shoppingCart.StergeDinCos(produsSelectat);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult CurataCos()
        {
            _shoppingCart.CurataCart();
            return RedirectToAction("Index");
        }
    }
}
