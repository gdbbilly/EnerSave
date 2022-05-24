using System;

namespace EnerSave.Views.ViewModels
{
    public class DescarteLixoViewModel
    {
        public int Id { get; set; }
        public decimal Peso { get; set; }
        public DateTime? Periodo { get; set; }
        public bool Organico { get; set; }
        public bool Reciclavel { get; set; }
        public bool Eletronico { get; set; }
        public string Observacao { get; set; }
        public int UsuarioId { get; set; }
    }
}
