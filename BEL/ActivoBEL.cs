using System;

namespace BEL
{
    public class ActivoBEL : EntidadBase
    {
        public string FechaAlta { get; set; } = "";
        public string FechaCompra { get; set; } = "";
        public string Inventario { get; set; } = string.Empty;
        public string Serie { get; set; }= string.Empty;
        public SectorBEL Sector { get; set; } = new SectorBEL();
        public UbicacionBEL Ubicacion { get; set; } = new UbicacionBEL();
        public EstadoBEL EstadoActivo { get; set; } = new EstadoBEL();
        public TipoActivoBEL TipoActivo { get; set; } = new TipoActivoBEL();
        public EmpresaBEL Organizacion { get; set; } = new EmpresaBEL();
        public MarcaBEL Marca { get; set; } = new MarcaBEL();
        public MonedaBEL Moneda { get; set; } = new MonedaBEL() { Id=1};
        public double ValorCompra { get; set; }
        public double ValorSoporte { get; set; }
        public int MesesGarantia { get; set; }
        public string Observaciones { get; set; } = "";
        public int Volumen { get; set; }
        public bool EnGarantia
        {
            get
            {
                if(MesesGarantia==0) return false;
                if (FechaCompra == "") return false;
                return Convert.ToDateTime(FechaCompra).AddMonths(MesesGarantia) > DateTime.Now;
            }
        }
        public override string ToString()
        {
            return $"Inv: {Inventario} / Tipo: {TipoActivo.Descripcion} / Desc: {Descripcion}";
        }

        public override bool Equals(object obj)
        {
            if (obj is ActivoBEL)
            {
                return Id.Equals(((ActivoBEL)obj).Id);
            }
            else return false;

        }
    }
}
