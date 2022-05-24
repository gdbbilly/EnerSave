using System;

namespace EnerSave.Views.ViewModels
{
    public class DescarteLixoViewModel
    {
        public int Id { get; set; }
        public decimal Peso { get; set; }
        public DateTime? Periodo { get; set; }
        public decimal Organico { get; set; }
        public decimal Reciclavel { get; set; }
        public int UsuarioId { get; set; }
    }
}
