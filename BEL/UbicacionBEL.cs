namespace BEL
{
    public class UbicacionBEL : Entidad
    {
        public string Direccion { get; set; } = "";

        public override string ToString()
        {
            return Descripcion;
        }

        public override bool Equals(object obj)
        {
            if (obj is UbicacionBEL)
                return Id.Equals(((UbicacionBEL)obj).Id);
            else return false;
        }
    }
}
