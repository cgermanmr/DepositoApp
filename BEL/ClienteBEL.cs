using System.Collections.Generic;

namespace BEL
{
    public class ClienteBEL : EntidadBase
    {
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public EmpresaBEL Empresa { get; set; } = new EmpresaBEL();
        public List<ActivoBEL> ActivosAsignados { get; set; } = new List<ActivoBEL>();

        public override string Descripcion { get => $"{Nombre} {Apellido}"; set => base.Descripcion = value; }

        public override string ToString() => $"{Nombre} {Apellido}";
    }
}
