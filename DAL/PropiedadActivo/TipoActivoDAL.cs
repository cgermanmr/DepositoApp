using System.Data;
using System.Linq;
using System;
using BEL;
using Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    public class TipoActivoDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_ACTIVO_TIPO";

        public override EntidadBase GetNew => new TipoActivoBEL();

        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<TipoActivoBEL> _lista = new List<TipoActivoBEL>();
            TipoActivoBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new TipoActivoBEL();
                x.Id = Convert.ToInt32(dr[0]);
                x.Descripcion = dr[1].ToString().Trim();
                x.Volumen = Convert.IsDBNull(dr[2])? 0 : Convert.ToInt32(dr[2]); 
                _lista.Add(x);
            }
            return _lista.ConvertAll(_ => (EntidadBase)_);
        }

        protected override Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();

            if (valor == null) valor = GetNew;
            hdatos.Add("@cod", valor.Id);
            hdatos.Add("@des", valor.Descripcion);
            hdatos.Add("@vol", ((TipoActivoBEL)valor).Volumen);

            return hdatos;
        }


    }
}
