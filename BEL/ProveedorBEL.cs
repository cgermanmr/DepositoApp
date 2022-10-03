namespace BEL
{
    public class ProveedorBEL : Entidad
    {
        public string RazonSocial { get; set; } = "";
        public long CUIT { get; set; }
        public string Direccion { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public string Observaciones { get; set; } = "";
        public override string ToString()
        {
            return $"{RazonSocial} (CUIT: {CUIT})";
        }
    }
}
