using POSCelulares.Entities.Common;

namespace POSCelulares.Entities
{
    public class Proveedor : BaseAuditable
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
