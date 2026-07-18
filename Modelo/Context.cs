using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        
        private string conexion = "Data Source=YASMIN-PC\\SQLEXPRESS;Initial Catalog=TechStore;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;";

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Descuento> Descuento { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<TipoCliente> TipoCliente { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        //navegacion de 1aN
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Venta>().ToTable("Venta");
            modelBuilder.Entity<DetalleVenta>().ToTable("DetalleVenta");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<MetodoPago>().ToTable("MetodoPago");
            modelBuilder.Entity<Factura>().ToTable("Factura");
            modelBuilder.Entity<Descuento>().ToTable("Descuento");
            modelBuilder.Entity<Sucursal>().ToTable("Sucursal");
            modelBuilder.Entity<TipoCliente>().ToTable("TipoCliente");
            modelBuilder.Entity<Inventario>().ToTable("Inventario");
            modelBuilder.Entity<Vendedor>().ToTable("Vendedor");
            
            modelBuilder.Entity<Producto>()
                .HasIndex(p => p.Codigo)
                .IsUnique();

            modelBuilder.Entity<Inventario>()
                .HasOne(i => i.Producto)
                .WithMany(p => p.Inventarios)
                .HasForeignKey(i => i.ProductoId);

            modelBuilder.Entity<Inventario>()
                .HasOne(i => i.Sucursal)
                .WithMany(s => s.Inventarios)
                .HasForeignKey(i => i.SucursalId);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Vendedor)
                .WithMany(vd => vd.Ventas)
                .HasForeignKey(v => v.VendedorId);

            modelBuilder.Entity<DetalleVenta>()
                .HasKey(dv => new { dv.VentaId, dv.ProductoId });

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Venta)
                .WithMany(v => v.Detalles)
                .HasForeignKey(dv => dv.VentaId);

            modelBuilder.Entity<DetalleVenta>()
                .HasOne(dv => dv.Producto)
                .WithMany(p => p.Detalles)
                .HasForeignKey(dv => dv.ProductoId);

            modelBuilder.Entity<Factura>()
                .HasOne(f => f.Venta)
                .WithOne(v => v.Factura)
                .HasForeignKey<Factura>(f => f.VentaId);

            modelBuilder.Entity<Inventario>()
                .HasKey(i => new { i.ProductoId, i.SucursalId });

            modelBuilder.Entity<TipoCliente>().HasData(
                new TipoCliente
                {
                    TipoClienteId = 1,
                    Nombre = "Mayorista"
                },
                new TipoCliente
                {
                    TipoClienteId = 2,
                    Nombre = "Minorista"
                }
            );

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);

    }
}
