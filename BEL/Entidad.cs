using System.Text;
using System.Reflection;
namespace BEL
{
    public abstract class EntidadBase
    {
        public long Id { get; set; }
        public virtual string Descripcion { get; set; } = "";
        public virtual bool Estado { get; set; } = true;

        //public string UsuarioModificador { get; set; } = "";
        //public System.DateTime FechaModificacion { get; set; } 
        //public TipoModificacion TipoModificacion { get; set; }
        //public TipoEvento TipoEvento { get; set; } = TipoEvento.Informacion;

    }
}
