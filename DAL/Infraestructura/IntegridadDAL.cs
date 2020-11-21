using System.Data;

namespace DAL
{
    public class IntegridadDAL
    {
        public static DataSet ObtenerTablasAVerificar()
        {
            DataSet ds = new DataSet();
            DataTable dt = Datos.ObtenerDataTable("SELECT * FROM USUARIO");
            dt.TableName = "USUARIO";
            ds.Tables.Add(dt);

            dt = Datos.ObtenerDataTable("SELECT * FROM DVV");
            dt.TableName = "DVV";
            ds.Tables.Add(dt);

            return ds;
        }

        public static bool ModificarTablasDV(DataSet ds)
        {
            bool modificacion=false;
            foreach (DataTable dt in ds.Tables)
                modificacion = modificacion | Datos.Actualizar("select * from " + dt.TableName, dt)>0;
            return modificacion;
        }
    }
}
