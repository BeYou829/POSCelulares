using POSCelulares.Entities.Common;

namespace POSCelulares.Entities
{
    public class DetalleVenta : BaseAuditable
    {
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Venta Venta { get; set; }
        public Producto Producto { get; set; }
    }
}
