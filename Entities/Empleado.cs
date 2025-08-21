using POSCelulares.Entities.Common;

namespace POSCelulares.Entities
{
    public class Empleado : BaseAuditable
    {
        public string Nombre { get; set; }
        public string Rol { get; set; }
        public string Usuario { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
