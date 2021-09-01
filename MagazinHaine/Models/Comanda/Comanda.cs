using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinHaine.Models
{
    public class Comanda
    {
        [BindNever]
        public int ComandaId { get; set; }
        [Required(ErrorMessage = "Te rog introdu numele de familie")]
        [Display(Name ="Nume de familie")]
        [StringLength(30)]
        public string NumeFamilie { get; set; }
        [Required(ErrorMessage = "Te rog introdu prenumele")]
        [Display(Name = "Prenume")]
        [StringLength(45)]
        public string Prenume { get; set; }
        [Required(ErrorMessage = "Te rog introdu adresa")]
        [Display(Name = "Adresa strazii")]
        [StringLength(100)]
        public string  Adresa { get; set; }
        [Required(ErrorMessage = "Te rog introdu orasul")]
        public string  Oras { get; set; }
        [Required(ErrorMessage = "Te rog introdu codul postal")]
        [StringLength(6, MinimumLength = 6)]
        public string CodPostal { get; set; }
        [Required(ErrorMessage = "Te rog introdu numarul de telefon")]
        [DataType(DataType.PhoneNumber)]
        public string NumarTelefon { get; set; }

        public List<DetaliuComanda> DetaliiComanda { get; set; }
        [BindNever]
        public decimal TotalComanda { get; set; }
        [BindNever]
        
        public DateTime ComandaPlasata { get; set; }
    }
}
