using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace DAL
{
    static class CacheDatos
    {
        public static List<EstadoBEL> Estados { get; set; }
        public static List<SectorBEL> Sectores { get; set; }
        public static List<UbicacionBEL> Ubicaciones { get; set; }
        public static List<TipoActivoBEL> Tipos { get; set; }
        public static List<MarcaBEL> Marcas { get; set; }
        public static List<EmpresaBEL> Organizaciones { get; set; }
        //public static List<ActivoBEL> Activos { get; set; } 

        public static List<PermisoBase> Permisos { get; set; }
               
    }
}
