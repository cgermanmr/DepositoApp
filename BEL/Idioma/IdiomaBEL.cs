using System;
using System.Collections.Generic;

namespace BEL
{
    public class IdiomaBEL
    {  
        private List<LeyendaBEL> _leyendas = new List<LeyendaBEL>();
        public List<LeyendaBEL> Leyendas
        {
            get
            {
                return _leyendas;
            }
            set
            {
                _leyendas.Clear();
                _leyendas.AddRange(value);
            }
        }
        public bool Habilitado { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public LeyendaBEL ObtenerLeyenda(LeyendaBEL valor)
        {
            return Leyendas.Find(x => x.Codigo == valor.Codigo);
        }

        public LeyendaBEL ObtenerLeyenda(string CodigoLeyenda)
        {
            return (ObtenerLeyenda(new LeyendaBEL() { Codigo=CodigoLeyenda}));
        }

        public override bool Equals(object obj)
        {
            if (!(obj == null))
            {
                if (obj is IdiomaBEL)
                    return Nombre.Equals(((IdiomaBEL)obj).Nombre);
                else if (obj is string)
                    return Nombre.Equals(obj);
                else
                    return false;
            }
            else
                return false;
        }

        public override string ToString()
        {
            return Nombre;
        }                 
    }
}
