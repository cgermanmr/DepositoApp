using System.Collections.Generic;

namespace Interfaces
{
    public interface ICRUD<T>
    {
        bool Agregar(T valor);
        bool Modificar(T valor);
        bool Eliminar(T valor);
        List<T> Listar();
        List<T> Listar(string filtro);
        List<T> Listar(T filtro);
        T ObtenerUno(T filtro);
    }
}
