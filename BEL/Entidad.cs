using System.Text;
using System.Reflection;
namespace BEL
{
    public abstract class Entidad
    {
        public long Id { get; set; }
        public virtual string Descripcion { get; set; } = "";
        public virtual bool Estado { get; set; } = true;
               
    }
}
