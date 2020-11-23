using System.Data;
using System.Collections;
using System.Collections.Generic;
using System;
using BEL;
using Interfaces;
using System.Transactions;

namespace DAL
{
    public class IdiomaDAL : ICRUD<IdiomaBEL>
    {
        public bool RegistrarLeyenda(LeyendaBEL valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codLeyenda", valor.Codigo);

            resultado = datos.Escribir("SP_LEYENDA_REGISTRAR", hdatos);

            return resultado;
        }

        public bool Agregar(IdiomaBEL valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codIdioma", valor.Nombre);
            hdatos.Add("@descripcion", valor.Descripcion);
            using (TransactionScope scope = new TransactionScope())
            {
                resultado = datos.Escribir("SP_IDIOMA_AGREGAR", hdatos);

                foreach (var item in valor.Leyendas)
                {
                    hdatos.Clear();
                    hdatos.Add("@codLeyenda", item.Codigo);
                    hdatos.Add("@codIdioma", valor.Nombre);
                    hdatos.Add("@valor", item.Valor);

                    resultado = resultado && datos.Escribir("SP_LEYENDA_AGREGAR", hdatos);
                }

                scope.Complete();
            }
            return resultado;
        }
    

        public bool Eliminar(IdiomaBEL valor)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@codIdioma", valor.Nombre);
            resultado = datos.Escribir("SP_IDIOMA_ELIMINAR", hdatos);
            return resultado;
        }

        public bool Modificar(IdiomaBEL valor)
        {
            bool resultado;
            using (TransactionScope scope = new TransactionScope())
            {
                resultado = Eliminar(valor) && Agregar(valor);    
                scope.Complete();                    
            }
            return resultado;
        }

        public IdiomaBEL ObtenerUno(IdiomaBEL filtro)
        {
            return Listar().Find(x => x.Nombre == filtro.Nombre);
           
        }

        private List<LeyendaBEL> ObtenerLeyendasdeIdioma(string nombreIdioma)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            hdatos.Add("@codIdioma", nombreIdioma);
            DataSet ds = datos.Leer("SP_LEYENDAS_POR_IDIOMA", hdatos);
            List<LeyendaBEL> leyendas = new List<LeyendaBEL>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                leyendas.Add(
                    new LeyendaBEL()
                        {
                            Codigo = dr["COD_LEYENDA"].ToString(),
                            Valor = dr["VALOR"].ToString()                      
                        }
                    );
            }

            return leyendas;
        }

        public List<IdiomaBEL> Listar()
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            DataSet ds = datos.Leer("SP_IDIOMA_LISTAR", null);
            List<IdiomaBEL> idiomas = new List<IdiomaBEL>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                idiomas.Add(
                    new IdiomaBEL
                    {
                        Nombre = dr["COD_IDIOMA"].ToString(),
                        Descripcion = dr["DESCRIPCION"].ToString(),
                        Leyendas = ObtenerLeyendasdeIdioma(dr["COD_IDIOMA"].ToString())
                        }
                    );
            }

            return idiomas;
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
