using System.Data;
using Microsoft.VisualBasic;
using System.Linq;
using BEL;
using System;
using Interfaces;
using System.Collections.Generic;
using System.Collections;
using Interfaces;

namespace DAL
{
    public class BitacoraDAL : ICRUD<BitacoraBEL>
    {
        protected BitacoraBEL DataRowToEntidad(DataRow dr)
        {
            int _Id = (int)dr["COD_BITACORA"];
            DateTime _Fecha = (DateTime)dr["FECHA"];          
            string _Descripcion = dr["DESCRIPCION"].ToString();
            string _Usuario = dr["COD_USUARIO"].ToString();
            TipoEvento _evento = (TipoEvento)dr["EVENTO"];
            return new BitacoraBEL() { Id = _Id,
                                      Fecha = _Fecha,
                                      Descripcion =_Descripcion,
                                      Usuario = _Usuario,
                                      Evento=_evento
            };
        }

        protected void EntidadToDataRow(object valor, DataRow dr)
        {
            BitacoraBEL b = (BitacoraBEL)valor;
            dr["COD_BITACORA"] = b.Id;
            dr["FECHA"] = b.Fecha;
            dr["DESCRIPCION"] = b.Descripcion;
            dr["COD_USUARIO"] = b.Usuario;
            dr["EVENTO"] = b.Evento;
        }

        public BitacoraBEL ObtenerUno(BitacoraBEL filtro)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(BitacoraBEL valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@EVENTO", valor.Evento);
            hdatos.Add("@FECHA", valor.Fecha);
            hdatos.Add("@DESCRIPCION", valor.Descripcion);
            hdatos.Add("@COD_USUARIO", valor.Usuario);       
           
            resultado = datos.Escribir("SP_BITACORA_AGREGAR", hdatos);
             
            return resultado;
        }

        public bool Modificar(BitacoraBEL valor)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BitacoraBEL valor)
        {
            throw new NotImplementedException();
        }

        public List<BitacoraBEL> Listar()
        {
            var datos = new Datos();
            DataSet ds = datos.Leer("SP_BITACORA_LISTAR", null);
            List<BitacoraBEL> eventos = new List<BitacoraBEL>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                eventos.Add(DataRowToEntidad(dr));
            }
            return eventos;
        }

        public List<BitacoraBEL> Listar(BitacoraBEL filtro)
        {
            throw new NotImplementedException();
        }
    }
}
