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
        public static void RegistrarEnBitacora(string pDescripcion, TipoEvento tipo = TipoEvento.Auditoria)
        {
            BitacoraBEL b = new BitacoraBEL
            {
                Fecha = DateTime.Now,
                Descripcion = pDescripcion,
                Evento=tipo
            };
            b.Usuario = (Sesion.SesionActual().ObtenerUsuarioActual!= null) ? Sesion.SesionActual().ObtenerUsuarioActual.Nombre : "No registrado";

            new BitacoraDAL().Agregar(b);
        }

        public static List<BitacoraBEL> Listar()
        {
            return new BitacoraDAL().Listar();
        }
       
    }
}
