using System;

namespace ConsultasMVC.dbenersave
{
    public partial class TdescarteLixo
    {
        public int Id { get; set; }
        public decimal MetrosCubicos { get; set; }
        public DateTime? Periodo { get; set; }
        public long UsuarioId { get; set; }
    }
}
