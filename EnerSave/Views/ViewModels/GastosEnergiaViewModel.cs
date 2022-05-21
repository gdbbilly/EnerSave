using System;

namespace EnerSave.Views.ViewModels
{
    public class GastosEnergiaViewModel
    {
        public int Id { get; set; }
        public decimal Kwh { get; set; }
        public DateTime? Periodo { get; set; }
        public long UsuarioId { get; set; }
    }
}
