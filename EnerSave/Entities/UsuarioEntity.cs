using System;
using System.ComponentModel.DataAnnotations;

namespace ConsultasMVC.Entities
{
    public partial class UsuarioEntity
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
