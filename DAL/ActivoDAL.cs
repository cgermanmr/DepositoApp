using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Collections;
using Interfaces;

namespace DAL
{
    public class ActivoDAL : Repositorio
    {
        public ActivoBEL GetById(int id)
        {
            return (ActivoBEL)ObtenerUno(new ActivoBEL() { Id = id });
        }
        protected override string ProcedimientoAlmacenado => "SP_ACTIVO";
        public override EntidadBase GetNew => new ActivoBEL();
        protected override List<EntidadBase> ObtenerLista(DataSet ds)
        {
            List<EntidadBase> _lista = new List<EntidadBase>();
            ActivoBEL x;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                x = new ActivoBEL();
                x.Id = (int)dr[0];
                x.FechaAlta = ((DateTime)dr[1]).ToString("dd/MM/yyyy");
                x.Inventario = Convert.IsDBNull(dr[2]) ? string.Empty : dr[2].ToString();
                x.Serie = Convert.IsDBNull(dr[3]) ? string.Empty : dr[3].ToString();
                x.Descripcion = Convert.IsDBNull(dr[4]) ? string.Empty : dr[4].ToString();
                x.Sector = (SectorBEL)new SectorDAL().ObtenerUno(new SectorBEL() { Id = (int)dr[5] });
                x.Ubicacion = (UbicacionBEL)new UbicacionDAL().ObtenerUno(new UbicacionBEL() { Id = (int)dr[6] });
                x.EstadoActivo = (EstadoBEL)new EstadoDAL().ObtenerUno(new EstadoBEL() { Id = (int)dr[7] });
                x.TipoActivo = (TipoActivoBEL)new TipoActivoDAL().ObtenerUno(new TipoActivoBEL() { Id = (int)dr[8] });
                x.Marca = (MarcaBEL)new MarcaDAL().ObtenerUno(new MarcaBEL() { Id = (int)dr[9] });
                x.Organizacion = (EmpresaBEL)new EmpresaDAL().ObtenerUno(new EmpresaBEL() { Id = (int)dr[10] });
                x.Moneda = (MonedaBEL)new MonedaDAL().ObtenerUno(new MonedaBEL() { Id = (int)dr[11] });
                x.ValorCompra = Convert.IsDBNull(dr[12]) ? 0.0 : (double)dr[12];
                x.ValorSoporte = Convert.IsDBNull(dr[13]) ? 0.0 : (double)dr[13];
                x.FechaCompra = Convert.IsDBNull(dr[14]) ? "" : ((DateTime)dr[14]).ToString("dd/MM/yyyy");
                x.MesesGarantia = Convert.IsDBNull(dr[15]) ? 0 : Convert.ToInt32(dr[15]);
                x.Volumen = Convert.IsDBNull(dr[16]) ? 0 : (int)dr[16];
                x.Observaciones = Convert.IsDBNull(dr[17]) ? string.Empty : (string)dr[17];
                _lista.Add(x);            
            }
            return _lista;
        }
        protected override Hashtable ObtenerParametros(EntidadBase valor)
        {
            var hdatos = new Hashtable();
            ActivoBEL _dato = valor == null ? (ActivoBEL)GetNew : (ActivoBEL)valor;

            hdatos.Add("@id", _dato.Id);
            hdatos.Add("@fecha_alta", _dato.FechaAlta);
            hdatos.Add("@nro_inventario", _dato.Inventario);
            hdatos.Add("@nro_serie", _dato.Serie);
            hdatos.Add("@descripcion", _dato.Descripcion);
            hdatos.Add("@sector", _dato.Sector.Id);
            hdatos.Add("@ubicacion", _dato.Ubicacion.Id);
            hdatos.Add("@estado", _dato.EstadoActivo.Id);
            hdatos.Add("@tipo", _dato.TipoActivo.Id);
            hdatos.Add("@marca", _dato.Marca.Id);
            hdatos.Add("@organizacion", _dato.Organizacion.Id);
            hdatos.Add("@moneda", _dato.Moneda.Id);
            hdatos.Add("@valor_compra", _dato.ValorCompra);
            hdatos.Add("@fecha_compra", _dato.FechaCompra);
            hdatos.Add("@meses_garantia", _dato.MesesGarantia);
            hdatos.Add("@volumen", _dato.Volumen);
            hdatos.Add("@observaciones", _dato.Observaciones);

            return hdatos;
        }

        public override List<EntidadBase> Listar(string filtro)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@TextoFiltro", filtro);

            DataSet ds = _datos.Leer("GetActivoFiltro", parametros);

            return ObtenerLista(ds);
        }

    }
}
