using System.Data;
using System.Linq;
using BEL;
using Interfaces;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DAL
{
    public class ProveedorDAL : Repositorio
    {
        protected override string ProcedimientoAlmacenado => "SP_PROVEEDOR";

        public override Entidad GetNew => new ProveedorBEL();

        protected override List<Entidad> ObtenerLista(DataSet ds)
        {
            List<ProveedorBEL> _lista = new List<ProveedorBEL>();
            ProveedorBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new ProveedorBEL();
                x.Id = Convert.ToInt32(dr[0]);
                x.RazonSocial = Convert.IsDBNull(dr[1]) ? string.Empty : dr[1].ToString();
                x.CUIT = Convert.IsDBNull(dr[2]) ? 0 : Convert.ToInt64(dr[2]);
                x.Direccion = Convert.IsDBNull(dr[3]) ? string.Empty : dr[3].ToString();
                x.Telefono = Convert.IsDBNull(dr[4]) ? string.Empty : dr[4].ToString();
                x.Observaciones = dr[5].ToString();
                x.Estado = (bool)dr[6];
                x.Email = Convert.IsDBNull(dr[7]) ? string.Empty : dr[7].ToString();

                _lista.Add(x);
            }

            return _lista.ConvertAll(_=>(Entidad)_);
        }

        protected override Hashtable ObtenerParametros(Entidad valor)
        {
            var hdatos = new Hashtable();
            ProveedorBEL x = (ProveedorBEL)valor;

            if (x == null) x = new ProveedorBEL();
            hdatos.Add("@id", x.Id);
            hdatos.Add("@razonsocial", x.RazonSocial);
            hdatos.Add("@cuit", x.CUIT);
            hdatos.Add("@direccion", x.Direccion);
            hdatos.Add("@telefono", x.Telefono);
            hdatos.Add("@email", x.Email);
            hdatos.Add("@obs", x.Observaciones);
            hdatos.Add("@estado", x.Estado);

            return hdatos;
        }

        public override List<Entidad> Listar(string filtro)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@TextoFiltro", filtro);

            DataSet ds = _datos.Leer("GetProveedorFiltro", parametros);

            return ObtenerLista(ds);
        }

        public ProveedorBEL GetByCuit(long cuit)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@cuit", cuit);
            parametros.Add("@operacion", 6);

            DataSet ds = _datos.Leer(ProcedimientoAlmacenado, parametros);

            return ObtenerLista(ds).Select(x => x as ProveedorBEL).
                FirstOrDefault();
        }

        
        public List<ProveedorBEL> ListarConOTPendientes()
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@operacion", 10);

            DataSet ds = _datos.Leer("SP_PROVEEDOR", parametros);

            return ObtenerLista(ds).Select( x => x as ProveedorBEL).ToList();
        }

    }
}
