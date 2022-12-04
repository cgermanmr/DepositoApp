using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

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

        public int CantPresupuestosAsignados => Presupuestos.Count;

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

        public double DemoraReparacion { 
            get 
            {
                var finalizacion = FechaFinalizacion != DateTime.MinValue
                    ? (DateTime)FechaFinalizacion 
                    : DateTime.Now;

                return (finalizacion - FechaSolicitud).TotalDays;
            }
        }

        public double CostoFinal { 
            get 
            { 
                if(Presupuestos.Count == 0) return 0;

                if (Presupuestos.Any(x => x.Autorizado))
                    return Presupuestos.FirstOrDefault(p => p.Autorizado).Cotizacion;

                return 0;


            } 
        }
    }
}
