using System.Collections.Generic;

namespace BEL
{
    public class DepositoBEL : EntidadBase
    {
        public int Capacidad { get; set; }

        public int CapacidadUtilizada
        {
            get {
                int _utilizado=0;
                Activos.ForEach(x => _utilizado += x.Volumen);
                return _utilizado;
            }
        }

        public int PorcentajeUtilizado {
            get {
                if (Capacidad == 0) return 0;
                double _porcentaje = (System.Convert.ToDouble(CapacidadUtilizada) / System.Convert.ToDouble(Capacidad))*100;
                return System.Convert.ToInt32(_porcentaje);
            }
        }
        public int PorcentajeDisponible { get { return 100 - PorcentajeUtilizado; } }

        public int ActivosDisponibles {
            get
            {
                return Activos.FindAll(_ => _.EstadoActivo.Id == (int)Estados.Disponible).Count;
            }
        }

        public int ActivosEnReparacion
        {
            get
            {
                return Activos.FindAll(_ => _.EstadoActivo.Id == (int)Estados.EnReparacion).Count;
            }
        }

        public int ActivosEnUso
        {
            get
            {
                return Activos.FindAll(_ => _.EstadoActivo.Id == (int)Estados.EnUso).Count;
            }
        }
        public int ActivosParaDonar
        {
            get
            {
                return Activos.FindAll(_ => _.EstadoActivo.Id == (int)Estados.ParaDonar).Count;
            }
        }
        public int ActivosParaDescartar
        {
            get
            {
                return Activos.FindAll(_ => _.EstadoActivo.Id == (int)Estados.ParaDescartar).Count;
            }
        }

        public UbicacionBEL Ubicacion { get; set; } = new UbicacionBEL();
        public List<ActivoBEL> Activos { get; set; } = new List<ActivoBEL>();
        public override string ToString()
        {
            return base.Descripcion;
        }
    }
}
