using System;
using System.Collections.Generic;
namespace BEL
{
    public class ReparacionBEL : Entidad
    {
        public ReparacionBEL()
        {
            Estado = true;
        }
        public ClienteBEL Solicitante { get; set; } = new ClienteBEL();
        public ActivoBEL Activo { get; set; } = new ActivoBEL();
        public string Descripcion { get; set; } = "";
        public List<PresupuestoBEL> Presupuestos { get; set; } = new List<PresupuestoBEL>();
        public DateTime FechaSolicitud { get; set; } = DateTime.Now;
        public DateTime? FechaFinalizacion { get; set; } = null;
        public bool Realizada => FechaFinalizacion > DateTime.MinValue;             
        public long TicketSoporte { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            return Id.Equals((obj as ReparacionBEL).Id);
        }
        public override string ToString()
        {
            return $"{Activo} \nFalla: {Descripcion}";
        }
    }
}
