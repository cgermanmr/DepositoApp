using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BEL;

namespace DAL
{
    public class DonacionDAL : Repositorio
    {
        public override EntidadBase GetNew => new DonacionBEL();

        protected override string ProcedimientoAlmacenado => "SP_DONACION";

        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<EntidadBase> _lista = new List<EntidadBase>();
            DonacionBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new DonacionBEL();
                x.Id = Convert.ToInt32(dr[0]);
                x.Autorizador = (ClienteBEL)new ClienteDAL().ObtenerUno(new ClienteBEL() { Id=(int)dr[1] });
                x.Auditor = (ClienteBEL)new ClienteDAL().ObtenerUno(new ClienteBEL() { Id = (int)dr[2] });
                x.Organizacion = (EmpresaBEL)new EmpresaDAL().ObtenerUno(new EmpresaBEL() {Id=(int)dr[3] });
                x.Fecha = dr[4].ToString();
                x.Estado = (bool)dr[5];
                x.Descripcion = dr[6].ToString();
                x.Activos = ObtenerListaActivos(x);
                _lista.Add(x);
            }

            return _lista;
        }

        private bool AgregarListaActivos(DonacionBEL donacion)
        {
            var datos = new Datos();
            bool resultado=true;
            
            foreach (var item in donacion.Activos)
            {
                Hashtable parametros = ObtenerParametros(donacion);
                parametros.Add("@operacion", 6);
                parametros["@activo"] = item.Id;
                resultado &= datos.Escribir(ProcedimientoAlmacenado, parametros);
            }           

            return resultado;
        }

        private bool EliminarListaActivos(DonacionBEL donacion)
        {
            var datos = new Datos();
            bool resultado = true;
            
            Hashtable parametros = ObtenerParametros(donacion);
            parametros.Add("@operacion", 7);
            resultado = datos.Escribir(ProcedimientoAlmacenado, parametros);

            return resultado;
        }

        private List<ActivoBEL> ObtenerListaActivos(DonacionBEL donacion)
        {
            var datos = new Datos();
           
            Hashtable parametros = ObtenerParametros(donacion);
            parametros.Add("@operacion", 8);
            DataSet ds = datos.Leer(ProcedimientoAlmacenado, parametros);

            List<ActivoBEL> _lista = new List<ActivoBEL>();
            ActivoDAL activoDAL=new ActivoDAL();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                _lista.Add((ActivoBEL)activoDAL.ObtenerUno(new ActivoBEL() { Id=(int)dr[1]}));
            }

            return _lista;
        }



        protected override Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();
            DonacionBEL _valor=(DonacionBEL)valor;
            if (_valor == null) _valor = new DonacionBEL();
            hdatos.Add("@codigo", _valor.Id);
            hdatos.Add("@autorizador", _valor.Autorizador.Id);
            hdatos.Add("@auditor", _valor.Auditor.Id);
            hdatos.Add("@fecha", _valor.Fecha);
            hdatos.Add("@obs", _valor.Descripcion);
            hdatos.Add("@estado", _valor.Estado);
            hdatos.Add("@org", _valor.Organizacion.Id);
            hdatos.Add("@activo", 0);
            return hdatos;
        }

        public override bool Agregar(EntidadBase valor)
        {
            bool result=false;

            using (TransactionScope scope = new TransactionScope())
            {
                result = base.Agregar(valor) && AgregarListaActivos((DonacionBEL)valor);
                                
                scope.Complete();
            }

            return result;            
        }

        public override bool Modificar(EntidadBase valor)
        {
            bool result = false;

            using (TransactionScope scope = new TransactionScope())
            {

                result = base.Modificar(valor) && 
                    EliminarListaActivos((DonacionBEL)valor) && 
                    AgregarListaActivos((DonacionBEL)valor);

                scope.Complete();
            }

            return result;
        }

        public override bool Eliminar(EntidadBase valor)
        {
            bool result = false;

            using (TransactionScope scope = new TransactionScope())
            {

                result = base.Eliminar(valor) &&
                    EliminarListaActivos((DonacionBEL)valor);

                scope.Complete();
            }

            return result;
        }

    }
}
