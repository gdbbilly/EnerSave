using System;

namespace ConsultasMVC.Entities
{
    public partial class DescarteLixoEntity
    {
        public int Id { get; set; }
        
        public decimal Peso { get; set; }
        
        public DateTime? Periodo { get; set; }
        
        public decimal Reciclavel { get; set; }
        
        public decimal Organico { get; set; }
        
        public int UsuarioId { get; set; }
        
        public virtual UsuarioEntity Usuario { get; set; }
    }
}
