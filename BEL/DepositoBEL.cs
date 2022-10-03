﻿using System.Collections.Generic;

namespace BEL
{
    public class DepositoBEL : Entidad
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
                     

        public UbicacionBEL Ubicacion { get; set; } = new UbicacionBEL();
        public List<ActivoBEL> Activos { get; set; } = new List<ActivoBEL>();
        public override string ToString()
        {
            return base.Descripcion;
        }
    }
}
