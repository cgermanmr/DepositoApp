using System;
using System.Collections.Generic;
using BEL;
using DAL;
using Interfaces;
using Servicios;

namespace BLL

{
    public abstract class Negocio : ICRUD<Entidad>
    {
       
        /// <summary>
        /// Indicar el mapeador de la clase
        /// </summary>
        /// <returns></returns>
        public abstract Repositorio Repositorio();
        /// <summary>
        /// validar reglas de negocio
        /// </summary>
        public virtual bool EsValido(Entidad valor) => true;
        public virtual bool Agregar(Entidad valor)
        {            
            EsValido(valor);
            Bitacora.RegistrarEnBitacora($"({valor.GetType().Name.Replace("BEL","")}) Alta { valor }");
            return Repositorio().Agregar(valor);
           
        }

        public virtual bool Eliminar(Entidad valor)
        {
            
            EsValido(valor);
            Bitacora.RegistrarEnBitacora($"({valor.GetType().Name.Replace("BEL", "")}) Baja {valor}");
            return Repositorio().Eliminar(valor);
           
        }

        public virtual List<Entidad> Listar()
        {
            return Repositorio().Listar();
        }

        public virtual List<Entidad> Listar(string filtro)
        {
            return Repositorio().Listar(filtro);
        }

        public virtual bool Modificar(Entidad valor)
        {
            EsValido(valor);
            Bitacora.RegistrarEnBitacora($"({valor.GetType().Name.Replace("BEL", "")}) Modificación {valor}");
            return Repositorio().Modificar(valor);
        }

        public virtual Entidad ObtenerUno(Entidad filtro)
        {
            return Repositorio().ObtenerUno(filtro);
        }

        public virtual Entidad GetById(long id)
        {
            var valor = Repositorio().GetNew;
            valor.Id = id;

            return ObtenerUno(valor);
        }

        public List<Entidad> Listar(Entidad filtro)
        {            
            return Repositorio().Listar(filtro);
        }
    }
}
