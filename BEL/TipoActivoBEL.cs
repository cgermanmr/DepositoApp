namespace BEL
{
    public class TipoActivoBEL : Entidad
    {
        public string Descripcion { get; set; }

        public int Volumen { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
