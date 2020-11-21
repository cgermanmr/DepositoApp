using System.Data;
using System.Linq;
using BEL;
using Interfaces;
using System.Collections;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class EmpresaDAL:Repository
    {
        protected override string ProcedimientoAlmacenado => "SP_EMPRESA";

        public override EntidadBase GetNew => new EmpresaBEL();

        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<EmpresaBEL> _lista = new List<EmpresaBEL>();
            EmpresaBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new EmpresaBEL();
                x.Id = Convert.ToInt32(dr[0]);
                x.RazonSocial = Convert.IsDBNull(dr[1]) ? string.Empty : dr[1].ToString();
                x.CUIT = Convert.IsDBNull(dr[2]) ? 0 : Convert.ToInt64(dr[2]);
                x.Direccion = Convert.IsDBNull(dr[3]) ? string.Empty : dr[3].ToString();
                x.CodigoPostal = Convert.IsDBNull(dr[4]) ? string.Empty : dr[4].ToString();
                x.Ciudad = Convert.IsDBNull(dr[5]) ? string.Empty : dr[5].ToString();
                x.Telefono = Convert.IsDBNull(dr[6]) ? string.Empty : dr[6].ToString();
                x.Email = Convert.IsDBNull(dr[7]) ? string.Empty : dr[7].ToString();
                x.Contacto = Convert.IsDBNull(dr[8]) ? string.Empty : dr[8].ToString();
                x.Observaciones = dr["OBSERVACIONES"].ToString();
                x.Estado = Convert.ToBoolean(dr["ESTADO"]);
                x.EsCliente = Convert.ToBoolean(dr["ESCLIENTE"]);

                _lista.Add(x);
            }

            return _lista.ConvertAll(_=>(EntidadBase)_);
        }

        protected override Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();
            EmpresaBEL x = (EmpresaBEL)valor;

            if (x == null) x = new EmpresaBEL();
            hdatos.Add("@codigo", x.Id);
            hdatos.Add("@razonsocial", x.RazonSocial);
            hdatos.Add("@cuit", x.CUIT);
            hdatos.Add("@direccion", x.Direccion);
            hdatos.Add("@cod_postal", x.CodigoPostal);
            hdatos.Add("@ciudad", x.Ciudad);
            hdatos.Add("@telefono", x.Telefono);
            hdatos.Add("@email", x.Email);
            hdatos.Add("@contacto", x.Contacto);
            hdatos.Add("@obs", x.Observaciones);
            hdatos.Add("@estado", x.Estado);
            hdatos.Add("@escliente", x.EsCliente);

            return hdatos;
        }     

    }
}
