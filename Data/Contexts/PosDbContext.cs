using Microsoft.EntityFrameworkCore;
using POSCelulares.Entities;

namespace POSCelulares.Data.Contexts
{
    public class PosDbContext(DbContextOptions<PosDbContext> options)
        : DbContext(options)
    {
        //Entidades
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
