using System.Data;
using System.Collections.Generic;
using System;
using BEL;
using Interfaces;
using System.Collections;
using System.Transactions;

namespace DAL
{
    public class ClienteDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_CLIENTE";

        public override EntidadBase GetNew => new ClienteBEL();

        protected override Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();
            ClienteBEL _valor = (ClienteBEL)valor;

            if (_valor == null) _valor = new ClienteBEL();
            hdatos.Add("@cod", _valor.Id);
            hdatos.Add("@apellido", _valor.Apellido);
            hdatos.Add("@nombre", _valor.Nombre);
            hdatos.Add("@telefono", _valor.Telefono);
            hdatos.Add("@email", _valor.Email);
            hdatos.Add("@empresa", _valor.Empresa==null? 0 : _valor.Empresa.Id);

            return hdatos;
        }
        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<EntidadBase> _lista = new List<EntidadBase>();
            ClienteBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new ClienteBEL();
                x.Id = Convert.ToInt32(dr[0]);
                x.Apellido = dr[1].ToString();
                x.Nombre = dr[2].ToString();
                x.Telefono = dr[3].ToString();
                x.Email = dr[4].ToString();
                bool idValido = int.TryParse(dr[5].ToString(), out int codEmpresa);
                if (idValido)
                    x.Empresa = (EmpresaBEL)new EmpresaDAL().ObtenerUno(new EmpresaBEL() { Id = Convert.ToInt32(codEmpresa) });
                x.ActivosAsignados = ObtenerListaDeActivos(x);
                _lista.Add(x);
            }

            return _lista;
        }
        private List<ActivoBEL> ObtenerListaDeActivos(ClienteBEL cliente)
        {
            var datos = new Datos();
            bool resultado;

            Hashtable parametros = ObtenerParametros(cliente);
            parametros.Add("@operacion", 6);

            DataSet ds= datos.Leer(ProcedimientoAlmacenado, parametros);

            List<ActivoBEL> _lista = new List<ActivoBEL>();
            ActivoBEL x;
            ActivoDAL activoDAL = new ActivoDAL();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = activoDAL.GetById(Convert.ToInt32(dr[1]));
                _lista.Add(x);
            }
            return _lista;
        }

        private bool EliminarActivosAsignados(EntidadBase cliente)
        {
            var datos = new Datos();
            bool resultado;
            Hashtable parametros = new Hashtable();
            parametros.Add("@codCli", cliente.Id);
            parametros.Add("@codAct", 0);
            parametros.Add("@operacion", 2);
            resultado = datos.Escribir("SP_ASIGNACION_ACTIVO", parametros);

            return resultado;
        }

        private bool AgregarActivosAsignados(EntidadBase cliente)
        {
            var _cliente = (ClienteBEL)cliente;
            var datos = new Datos();
            bool resultado=true;
            Hashtable parametros = new Hashtable();
                        
            foreach (var item in _cliente.ActivosAsignados)
            {
                parametros.Clear();
                parametros.Add("@codCli", cliente.Id);
                parametros.Add("@codAct", item.Id);
                parametros.Add("@operacion", 1);
                resultado = resultado && datos.Escribir("SP_ASIGNACION_ACTIVO", parametros);
            }
            return resultado;
        }
        public override bool Modificar(EntidadBase valor)
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
