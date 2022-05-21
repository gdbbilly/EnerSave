using System;

namespace ConsultasMVC.dbenersave
{
    public partial class TdescarteLixo
    {
        public int Id { get; set; }
        public decimal Peso { get; set; }
        public DateTime? Periodo { get; set; }
        public decimal Reciclavel { get; set; }
        public decimal Organico { get; set; }
        public long UsuarioId { get; set; }
    }
}
