using System.Collections.Generic;
using System;
using DAL;
using BEL;
using Interfaces;      
                
namespace Servicios
{
    public class Idioma : ICRUD<IdiomaBEL>
    {
        private IdiomaDAL _mapeadorIdioma = new IdiomaDAL();

        public bool RegistrarLeyenda(LeyendaBEL valor)
        {
            Sesion.SesionActual().IdiomaActual.Leyendas.Add(valor);
            return new IdiomaDAL().RegistrarLeyenda(valor);              
           
        }

        public bool Agregar(IdiomaBEL valor)
        {
            return _mapeadorIdioma.Agregar(valor);
           
        }
                
        public bool Eliminar(IdiomaBEL valor)
        {            
            return _mapeadorIdioma.Eliminar(valor);
        }

        public List<IdiomaBEL> Listar()
        {           
            return _mapeadorIdioma.Listar();            
        }

        public IdiomaBEL ObtenerUno(IdiomaBEL filtro)
        {
            return _mapeadorIdioma.ObtenerUno(filtro);
           
        }

        public bool Modificar(IdiomaBEL valor)
        {
            
            return _mapeadorIdioma.Modificar(valor);
           
        }

        public List<IdiomaBEL> Listar(IdiomaBEL filtro)
        {
            throw new NotImplementedException();
        }

        public List<IdiomaBEL> Listar(string filtro)
        {
            throw new NotImplementedException();
        }
    }
}
