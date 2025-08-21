using POSCelulares.Entities.Common;

namespace POSCelulares.Entities
{
    public class Venta : BaseAuditable
    {
        public DateTime FechaVenta { get; set; } = DateTime.Now;
        public decimal Total { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public ICollection<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }
}
