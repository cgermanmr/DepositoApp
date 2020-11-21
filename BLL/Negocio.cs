using System;
using System.Collections.Generic;
using BEL;
using DAL;
using Interfaces;

namespace BLL

{
    public abstract class Negocio : ICRUD<EntidadBase>
    {
        /// <summary>
        /// validar reglas de negocio
        /// </summary>
        public virtual void Validar(EntidadBase valor) { }
        /// <summary>
        /// Indicar el mapeador de la clase
        /// </summary>
        /// <returns></returns>
        public abstract Repository Repositorio();
        public virtual bool Agregar(EntidadBase valor)
        {
            try
            {
                Validar(valor);
                return Repositorio().Agregar(valor);
            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 7890);

                throw ex;
            }
        }

        public virtual bool Eliminar(EntidadBase valor)
        {
            try
            {
                Validar(valor);
                return Repositorio().Eliminar(valor);
            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 7890);

                throw ex;
            }
        }

        public virtual List<EntidadBase> Listar()
        {
            try
            {
                return Repositorio().Listar();
            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 7890);

                throw ex;
            }
        }

        public virtual List<EntidadBase> Listar(EntidadBase filtro)
        {
            try
            {
                return Repositorio().Listar(filtro);
            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 7890);

                throw ex;
            }
        }

        public virtual bool Modificar(EntidadBase valor)
        {
            try
            {
                Validar(valor);
                return Repositorio().Modificar(valor);
            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 7890);

                throw ex;
            }
        }

        public virtual EntidadBase ObtenerUno(EntidadBase filtro)
        {
            try
            {
                return Repositorio().ObtenerUno(filtro);
            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 7890);

                throw ex;
            };
        }

        public virtual EntidadBase GetById(int id)
        {
            try
            {
                var valor = Repositorio().GetNew;
                valor.Id = id;

                return ObtenerUno(valor);

            }
            catch (Exception ex)
            {
                Servicios.Logger.WriteLogExeption(ex, 7890);
                throw ex;
            }
        }
    }
}
