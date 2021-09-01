using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCardId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context)
            {
                ShoppingCardId = cartId
            };
        }
        public void AdaugaInCos (Produs produs, int cantitate)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault
                (s => s.Produs.ProdusId == produs.ProdusId && s.ShoppingCartId == ShoppingCardId);
            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCardId,
                    Produs = produs,
                    Cantitate = cantitate
                };
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            } 
            else
            {
                shoppingCartItem.Cantitate++;
            }
            _appDbContext.SaveChanges();
        }
        public int StergeDinCos(Produs produs)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault
                (s => s.Produs.ProdusId == produs.ProdusId && s.ShoppingCartId == ShoppingCardId);

            var localCantitate = 0;

            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Cantitate > 1)
                {
                    shoppingCartItem.Cantitate--;
                    localCantitate = shoppingCartItem.Cantitate;
                }
                else
                {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }
            _appDbContext.SaveChanges();

            return localCantitate;
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where
                (c => c.ShoppingCartId == ShoppingCardId)
                .Include(s => s.Produs)
                .ToList());
        }
        public void CurataCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCardId);
            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }
        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCardId)
                .Select(c => c.Produs.Pret * c.Cantitate).Sum();

            return total;

        }
    }
}
