namespace BEL
{
    public class SectorBEL : Entidad
    {

        public string CentroCosto { get; set; } = "";

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
