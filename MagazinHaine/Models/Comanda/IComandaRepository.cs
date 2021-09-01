using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public interface IComandaRepository
    {
        void CreazaComanda(Comanda comanda);
    }
}
