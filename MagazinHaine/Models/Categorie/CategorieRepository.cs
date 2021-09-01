using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class CategorieRepository : ICategorieRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategorieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Categorie> GetAllCategori => _appDbContext.Categorii;
        
    }
}
