using System.Data;
using System;
using System.Text;
using Comun;
using DAL;
using Interfaces;

namespace Servicios
{
    public class IntegridadDatos
    {

        private static bool ValidarEntidad(DataTable dt, string dvv)
        {
            bool resultado = true;
            StringBuilder salida = new StringBuilder();
      
            // Se recorre cada registro y se compara el hash generado con el guardado en la tabla
            foreach (DataRow registro in dt.Rows)
            {                     
                if (!Criptografia.Get.CompareHashMD5(RegistroToString(registro), registro["DVH"].ToString()))
                {
                    salida.AppendLine($"Registro corrupto en tabla {dt.TableName} código del registro: {registro[0]}");
                    resultado = false;
                }
            }

            if (!dvv.Equals(GenerarDVV(dt)))
            {
                salida.AppendLine($"Registro DVV corrupto para la tabla: {dt.TableName} ");
                resultado = false;
            }      

            if (resultado)
                salida.AppendLine($"DVH y DVV verificados correctamente en tabla {dt.TableName}");
           
            Logger.WriteLog(salida.ToString());

            Bitacora.RegistrarEnBitacora($"{salida}", TipoEvento.Seguridad);

            Console.WriteLine(salida);
            
            return resultado;
        }
        private static void GenerarDVHTabla(DataTable dt)
        {
            // Un procedimiento auxiliar para generar los digitos verificador de horizontal
            foreach (DataRow registro in dt.Rows)
                registro["DVH"] = Criptografia.Get.GetHashMD5(RegistroToString(registro));
        }
       
        private static string RegistroToString(DataRow registro)
        {
            StringBuilder sb = new StringBuilder();
            var loopTo = (registro.Table.Columns.Count - 2);
            // concateno todos los campos del registro en un solo string
            for (int index = 0; index <= loopTo; index++)
                sb.Append(registro[index].ToString());
            return sb.ToString();
        }
        private static string GenerarDVV(DataTable entidad)
        {
            StringBuilder sb = new StringBuilder();
            // concateno todos los campos de la columna DVH en un solo string
            foreach (DataRow registro in entidad.Rows)
                sb.Append(registro["DVH"].ToString());
            return Criptografia.Get.GetHashMD5(sb.ToString());
        }
        public static bool RegenerarDV()
        {
            DataSet ds = IntegridadDAL.ObtenerTablasAVerificar();
            foreach (DataTable dt in ds.Tables)
            {
                if (!dt.ToString().Equals("DVV"))
                {
                    GenerarDVHTabla(dt);
                    ds.Tables["DVV"].Select(string.Format("NOMBRE_TABLA ='{0}' ", dt.ToString()))[0]["DVV"] = GenerarDVV(dt);
                }
            }
            
            Bitacora.RegistrarEnBitacora($"Se regeneran digitos verificadores", TipoEvento.Seguridad);
            
            return IntegridadDAL.ModificarTablasDV(ds);
        }
        public static bool Verificar()
        {
            DataSet ds = IntegridadDAL.ObtenerTablasAVerificar();
            DataTable dvv = ds.Tables["DVV"];
            bool result = true;
            foreach (DataTable dt in ds.Tables)
            {
                if (!dt.TableName.Equals("DVV"))
                {
                    string verificador = dvv.Select(string.Format("NOMBRE_TABLA='{0}'",dt.TableName))[0]["DVV"].ToString();
                    result &=ValidarEntidad(dt, verificador);
                }
            }

            return result;
        }

    }
}
