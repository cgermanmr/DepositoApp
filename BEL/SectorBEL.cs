namespace BEL
{
    public class SectorBEL : EntidadBase
    {

        public string CentroCosto { get; set; } = "";

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
