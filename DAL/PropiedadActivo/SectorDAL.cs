using System.Data;
using System.Linq;
using BEL;
using Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    public class SectorDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_SECTOR";

        public override EntidadBase GetNew => new SectorBEL();

        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<SectorBEL> _lista = new List<SectorBEL>();
            SectorBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new SectorBEL();
                x.Id = (int)dr[0];
                x.Descripcion = dr[1].ToString().Trim();
                x.CentroCosto= dr[2].ToString().Trim();
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
            hdatos.Add("@cc", ((SectorBEL)valor).CentroCosto);

            return hdatos;
        }


    }
}
