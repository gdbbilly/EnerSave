using System;

namespace ConsultasMVC.dbenersave
{
    public partial class TgastosEnergia
    {
        public int Id { get; set; }
        public decimal Kwh { get; set; }
        public DateTime? Periodo { get; set; }
        public long UsuarioId { get; set; }
    }
}
