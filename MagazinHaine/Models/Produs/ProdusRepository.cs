using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class ProdusRepository : IProdusRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProdusRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Produs> GetAllProduse 
        {
            get
            {
                return _appDbContext.Produse.Include(c => c.Categorie);
            }
        }
        public IEnumerable<Produs> GetProdusDeVanzare
        {
            get
            {
                return _appDbContext.Produse.Include(c => c.Categorie).Where(p => p.EsteDeVanzare);
            }

        }

        public Produs GetProdusDupaId(int produsId)
        {
            return _appDbContext.Produse.FirstOrDefault(p => p.ProdusId == produsId);
        }
    }
}
