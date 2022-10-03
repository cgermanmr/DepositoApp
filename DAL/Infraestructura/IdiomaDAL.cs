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
            hdatos.Add("@habilitado", valor.Habilitado);

            using (TransactionScope scope = new TransactionScope())
            {
                resultado = datos.Escribir("SP_IDIOMA_AGREGAR", hdatos);

                AgregarLeyendas(valor);
              
                scope.Complete();
            }
            return resultado;
        }

        private bool EliminarLeyendas(string codIdioma)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();

            hdatos.Add("@codIdioma", codIdioma);
            hdatos.Add("@operacion", 7);

            return datos.Escribir("SP_IDIOMA", hdatos);

        }
        private bool AgregarLeyendas(IdiomaBEL idioma)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado = EliminarLeyendas(idioma.Nombre);

            foreach (var item in idioma.Leyendas)
            {
                hdatos.Clear();
                hdatos.Add("@codIdioma", idioma.Nombre);
                hdatos.Add("@codLeyenda", item.Codigo);
                hdatos.Add("@valorLeyenda", item.Valor);
                hdatos.Add("@operacion", 8);
                resultado &= datos.Escribir("SP_IDIOMA", hdatos);
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

        public bool Modificar(IdiomaBEL idioma)
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Clear();
            hdatos.Add("@codIdioma", idioma.Nombre);
            hdatos.Add("@descripcion", idioma.Descripcion);
            hdatos.Add("@habilitado", idioma.Habilitado);
            hdatos.Add("@operacion", 3);

            using (TransactionScope scope = new TransactionScope())
            {
                resultado = datos.Escribir("[SP_IDIOMA]", hdatos);

                resultado &= AgregarLeyendas(idioma);

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
                        Habilitado = (bool)dr["HABILITADO"],
                        Leyendas = ObtenerLeyendasdeIdioma(dr["COD_IDIOMA"].ToString())
                    });
            }

            return idiomas;
        }

        public List<IdiomaBEL> Listar(string filtro)
        {
            throw new NotImplementedException();
        }

        public List<IdiomaBEL> Listar(IdiomaBEL filtro)
        {
            throw new NotImplementedException();
        }
    }
}
