namespace DataLayer
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

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Tienda> Tiendas { get; set; }
        public virtual DbSet<Producto_Inventario> Producto_Inventario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Categoria)
                .HasForeignKey(e => e.id_categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inventario>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Inventario>()
                .HasMany(e => e.Producto_Inventario)
                .WithRequired(e => e.Inventario)
                .HasForeignKey(e => e.id_inventario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inventario>()
                .HasMany(e => e.Tiendas)
                .WithRequired(e => e.Inventario)
                .HasForeignKey(e => e.id_inventario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Productos)
                .WithRequired(e => e.Marca)
                .HasForeignKey(e => e.id_marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Producto_Inventario)
                .WithRequired(e => e.Producto)
                .HasForeignKey(e => e.id_producto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tienda>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Tienda>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Tienda>()
                .Property(e => e.direccion)
                .IsUnicode(false);
        }
    }
}
