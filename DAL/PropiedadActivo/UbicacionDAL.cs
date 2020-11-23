using System.Data;
using System.Linq;
using BEL;
using Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    public class UbicacionDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_ACTIVO_UBICACION";

        public override EntidadBase GetNew => new UbicacionBEL();

        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<UbicacionBEL> _lista = new List<UbicacionBEL>();
            UbicacionBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new UbicacionBEL();
                x.Id = (int)dr[0];
                x.Descripcion = dr[1].ToString().Trim();
                x.Direccion = dr[2].ToString().Trim();
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
            hdatos.Add("@dir", ((UbicacionBEL)valor).Direccion);

            return hdatos;
        }


    }
}
