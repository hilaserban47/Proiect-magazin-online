using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class ComandaRepository : IComandaRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;
        public ComandaRepository(AppDbContext appDbContext , ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreazaComanda(Comanda comanda)
        {
            comanda.ComandaPlasata = DateTime.Now;
            comanda.TotalComanda = _shoppingCart.GetShoppingCartTotal();
            _appDbContext.Comenzi.Add(comanda);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();
            foreach(var shoppingCartItem in shoppingCartItems)
            {
                var comandaDetaliu = new DetaliuComanda
                {
                    Cantitate = shoppingCartItem.Cantitate,
                    Pret = shoppingCartItem.Produs.Pret,
                    ProdusId = shoppingCartItem.Produs.ProdusId,
                    ComandaId = comanda.ComandaId

                };
                _appDbContext.DetaliiComanda.Add(comandaDetaliu);
            }
            _appDbContext.SaveChanges();
        }
    }
}
