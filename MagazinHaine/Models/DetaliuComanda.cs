using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class DetaliuComanda
    {
        public int DetaliuComandaId { get; set; }
        public int ComandaId { get; set; }
        public int ProdusId { get; set; }
        public Produs Produs { get; set; }
        public int Cantitate { get; set; }
        public decimal Pret { get; set; }
        public Comanda Comanda { get; set; }
    }
}
