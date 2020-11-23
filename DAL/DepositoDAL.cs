using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using BEL;
using Interfaces;
using System.Collections;

namespace DAL
{
    public class DepositoDAL :Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_DEPOSITO";

        public override EntidadBase GetNew => new DepositoBEL();

        protected override Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();
            DepositoBEL _valor = (DepositoBEL)valor;
            if (_valor == null) _valor = new DepositoBEL();
            hdatos.Add("@cod", _valor.Id);
            hdatos.Add("@des", _valor.Descripcion);
            hdatos.Add("@ubicacion", _valor.Ubicacion.Id);
            hdatos.Add("@capacidad",_valor.Capacidad);
            return hdatos;
        }
        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<EntidadBase> _lista = new List<EntidadBase>();
            DepositoBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new DepositoBEL();
                x.Id = (int)dr[0];
                x.Descripcion=dr[1].ToString();
                x.Capacidad = Convert.ToInt32(dr[2]);
                x.Ubicacion = (UbicacionBEL)new UbicacionDAL().Listar().Find(_=>((UbicacionBEL)_).Id==Convert.ToInt32(dr[3]));
                x.Activos = new ActivoDAL().Listar()
                    .FindAll(_ => 
                    ((ActivoBEL)_).Ubicacion.Equals(x.Ubicacion))
                    .ConvertAll(_=>(ActivoBEL)_);
                _lista.Add(x);
            }

            return _lista;
        }    

       
    }
}
