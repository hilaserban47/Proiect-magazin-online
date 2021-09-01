using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public interface IProdusRepository
    {
        IEnumerable<Produs> GetAllProduse { get; }
        IEnumerable<Produs> GetProdusDeVanzare { get; }
        Produs GetProdusDupaId(int produsId);
    }
}
