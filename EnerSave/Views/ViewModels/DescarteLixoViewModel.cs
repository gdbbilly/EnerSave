using System;

namespace EnerSave.Views.ViewModels
{
    public class DescarteLixoViewModel
    {
        public int Id { get; set; }
        public decimal MetrosCubicos { get; set; }
        public DateTime? Periodo { get; set; }
        public long UsuarioId { get; set; }
    }
}
