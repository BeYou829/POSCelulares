using POSCelulares.Entities.Common;

namespace POSCelulares.Entities
{
    public class Cliente : BaseAuditable
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Dirección { get; set; }
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
