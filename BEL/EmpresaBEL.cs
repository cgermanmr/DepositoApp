namespace BEL
{
    public class EmpresaBEL : Entidad
    {
        public string RazonSocial { get; set; } = "";
        public long CUIT { get; set; }
        public string Direccion { get; set; } = "";
        public string CodigoPostal { get; set; } = "";
        public string Ciudad { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public string Contacto { get; set; } = "";
        public string Observaciones { get; set; } = "";
        public bool EsCliente { get; set; }
        public override string ToString()
        {
            return RazonSocial;
        }
    }
}
