using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Comun;
using Interfaces;

namespace Servicios
{
    public class Bitacora
    {
        public static void RegistrarEnBitacora(string pDescripcion, 
            TipoEvento tipo = TipoEvento.Auditoria, 
            Criticidad criticidad = Criticidad.Baja,
            bool sistema = false)
        {
            BitacoraBEL b = new BitacoraBEL
            {
                Fecha = DateTime.Now,
                Descripcion = pDescripcion,
                Evento=tipo,
                Criticidad = criticidad
            };
            
            b.Usuario = sistema || Sesion.SesionActual().ObtenerUsuarioActual == null
                ? "SISTEMA" 
                : Sesion.SesionActual().ObtenerUsuarioActual.Nombre;

            new BitacoraDAL().Agregar(b);
        }

        public static List<BitacoraBEL> Listar()
        {
            return new BitacoraDAL().Listar();
        }
       
    }
}
