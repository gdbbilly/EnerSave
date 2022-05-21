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

        public virtual DbSet<TgastosEnergia> TgastosEnergia{ get; set; }

        public virtual DbSet<TdescarteLixo> TdescarteLixo { get; set; }

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


            modelBuilder.Entity<TgastosEnergia>(entity =>
            {
                entity.ToTable("tgastos_energia", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Kwh)
                    .HasColumnName("kwh");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usu_id");

            });


            modelBuilder.Entity<TdescarteLixo>(entity =>
            {
                entity.ToTable("tdescarte_lixo", "dbenersave");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Peso)
                    .HasColumnName("peso");

                entity.Property(e => e.Periodo)
                    .HasColumnName("periodo");

                entity.Property(e => e.Reciclavel)
                    .HasColumnName("reciclavel");

                entity.Property(e => e.Organico)
                    .HasColumnName("organico");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usu_id");

            });
        }
    }
}
