using System;
using System.Collections.Generic;
namespace BEL
{
    public class ReparacionBEL : EntidadBase
    {
        public ReparacionBEL()
        {
            Estado = false;
        }
        public ClienteBEL Solicitante { get; set; } = new ClienteBEL();
        public ActivoBEL Activo { get; set; } = new ActivoBEL();
        public string Descripcion { get; set; } = "";
        public string Observaciones { get; set; } = "";
        public List<PresupuestoBEL> Presupuestos { get; set; } = new List<PresupuestoBEL>();
        public string FechaSolicitud { get; set; } = "";

        public bool Realizada { get { return FechaFinalizacion != ""; } }

        private string _fechaFinalizacion="";
        public string FechaFinalizacion {
            get {
                if (_fechaFinalizacion == "01/01/1900 0:00:00") return "";
                else return _fechaFinalizacion;
            }
            set {
                _fechaFinalizacion = value;
            }
        }
        public int TicketSoporte { get; set; }
     
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            return Id.Equals(((ReparacionBEL)obj).Id);

        }
        public override string ToString()
        {
            return $"{Activo.ToString()} {Environment.NewLine}" +
                $"Falla: {Descripcion}";
        }
    }
}
