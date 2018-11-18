namespace Entities_Layer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TamboContext : DbContext
    {
        public TamboContext()
            : base("name=TamboContext")
        {
        }

        
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        
        public virtual DbSet<Tiendas> Tiendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Categorias>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Categorias)
                .HasForeignKey(e => e.id_categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marcas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Marcas>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Marcas>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Marcas)
                .HasForeignKey(e => e.id_marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.Inventario)
                .WithRequired(e => e.Productos)
                .HasForeignKey(e => e.id_producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tiendas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Tiendas>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Tiendas>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Tiendas>()
                .HasMany(e => e.Inventario)
                .WithRequired(e => e.Tiendas)
                .HasForeignKey(e => e.id_tienda)
                .WillCascadeOnDelete(false);
        }
    }
}
