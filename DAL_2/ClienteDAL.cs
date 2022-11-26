using System.Data;
using System.Collections.Generic;
using System;
using BEL;
using Interfaces;
using System.Collections;
using System.Transactions;
using System.Linq;
using Comun;

namespace DAL
{
    public class ClienteDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_CLIENTE";

        public override Entidad GetNew => new ClienteBEL();

        protected override Hashtable ObtenerParametros(Entidad valor)
        {
            var hdatos = new Hashtable();
            ClienteBEL _valor = (ClienteBEL)valor;

            if (_valor == null) _valor = new ClienteBEL();
            hdatos.Add("@id", _valor.Id);
            hdatos.Add("@apellido", _valor.Apellido);
            hdatos.Add("@nombre", _valor.Nombre);
            hdatos.Add("@telefono", _valor.Telefono);
            hdatos.Add("@email", _valor.Email);
            hdatos.Add("@empresa", _valor.Empresa==null? 0 : _valor.Empresa.Id);

            return hdatos;
        }
        protected override List<Entidad> ObtenerLista(DataSet ds)
        {
            List<Entidad> _lista = new List<Entidad>();
            ClienteBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new ClienteBEL();
                x.Id = dr[0].SafeToLong();
                x.Apellido = dr[1].ToString();
                x.Nombre = dr[2].ToString();
                x.Telefono = dr[3].ToString();
                x.Email = dr[4].ToString();
                x.Empresa = (EmpresaBEL)new EmpresaDAL().GetById(dr[5]);
                x.ActivosAsignados = ObtenerListaDeActivos(x);
                _lista.Add(x);
            }

            return _lista;
        }
        private List<ActivoBEL> ObtenerListaDeActivos(ClienteBEL cliente)
        {
            var datos = new Datos();

            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", 6);
            parametros.Add("@id", cliente.Id);

            DataSet ds= datos.Leer(ProcedimientoAlmacenado, parametros);

            List<ActivoBEL> _lista = new List<ActivoBEL>();
            ActivoDAL activoDAL = new ActivoDAL();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ActivoBEL x = activoDAL.GetById(dr[1]) as ActivoBEL;
                _lista.Add(x);
            }
            return _lista;
        }

        private bool EliminarActivosAsignados(Entidad cliente)
        {
            var c = cliente as ClienteBEL;
            var datos = new Datos();
            bool resultado;

            var eliminado = ObtenerListaDeActivos(c).Except(c.ActivosAsignados).FirstOrDefault();

            if (eliminado == null) return true;

            Hashtable parametros = new Hashtable();
            parametros.Add("@cliente", c.Id);
            parametros.Add("@activo", eliminado.Id);
            parametros.Add("@operacion", 2);
            resultado = datos.Escribir("SP_ASIGNACION_ACTIVO", parametros);

            return resultado;
        }

        private bool AgregarActivosAsignados(Entidad cliente)
        {
            var c = cliente as ClienteBEL;
            var datos = new Datos();

            var agregado = c.ActivosAsignados.Except(ObtenerListaDeActivos(c)).FirstOrDefault();

            if(agregado == null) return true;

            Hashtable parametros = new Hashtable();
           
            parametros.Add("@cliente", cliente.Id);
            parametros.Add("@activo", agregado.Id);
            parametros.Add("@operacion", 1);
            var resultado = datos.Escribir("SP_ASIGNACION_ACTIVO", parametros);

            return resultado;
        }
        public override bool Modificar(Entidad valor)
        {
            bool result = false;
            using (TransactionScope scope = new TransactionScope())
            {           
                result = EliminarActivosAsignados(valor) && AgregarActivosAsignados(valor);

                result = result && base.Modificar(valor);

                if (!result) throw new InvalidOperationException("No se pudo modificar");

                scope.Complete();
            }

            return result;
        }
    }
}
