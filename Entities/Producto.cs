using POSCelulares.Entities.Common;

namespace POSCelulares.Entities
{
    public class Producto : BaseAuditable
    {
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string? IMEI { get; set; }

        public ICollection<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
    }
}
