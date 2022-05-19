using Microsoft.EntityFrameworkCore;

namespace ConsultasMVC.dbenersave
{
    public partial class DbenersaveContext : DbContext
    {
        public DbenersaveContext()
        {
        }

        public DbenersaveContext(DbContextOptions<DbenersaveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TgastosAgua> TgastosAgua { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TgastosAgua>(entity =>
            {
                entity.ToTable("tgastos_agua", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.MetrosCubicos)
                    .HasColumnName("metros_cubicos");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usu_id");

            });
        }
    }
}
