using System;
using Interfaces;

namespace BEL
{
    public class BitacoraBEL : Entidad
    {
        public DateTime Fecha { get; set; }
        public TipoEvento Evento { get; set; } = TipoEvento.Informacion;
        public string Descripcion { get; set; }
        public string Usuario { get; set; }   
    }
}
