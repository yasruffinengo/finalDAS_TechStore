using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Modelo
{
    public class Context : DbContext
    {
        
        private string conexion = "Data Source=YASMIN-PC\\SQLEXPRESS;Initial Catalog=TechStore;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;";

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<MetodoPago> MetodosPago { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Descuento> Descuentos { get; set; }

        //navegacion de 1aN
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(conexion);

    
    

    }
}
