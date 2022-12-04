using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Collections;
using System.Configuration;
using Comun;

namespace DAL
{
    public static class ConfigDb
    {
        private static string connectionString;
        private static bool Ejecutar(ConfigDbBEL configDbDatos, string scriptFile)
        {
            string comando = File.ReadAllText($@"{AppContext.BaseDirectory}InitDb\{scriptFile}.sql");

            comando = comando.Replace("DepositoDB", $"{configDbDatos.NombreBase}");

            try
            {
                using (var thisconn = new Microsoft.Data.SqlClient.SqlConnection(connectionString))
                {
                    Server db = new Server(new ServerConnection(thisconn));
                    var respuesta = db.ConnectionContext.ExecuteNonQuery(comando);
                    return respuesta != 0;
                }
            }
            catch (Exception ex)
            {
                configDbDatos.Mensaje = ex.InnerException?.Message;
                return false;
            }

        }

        private static void ActualizarConectionString(string nombreBase)
        {
            connectionString+= $"Initial Catalog={nombreBase};";
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["DepositoDB"].ConnectionString = connectionString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            //Actualizar appkey nombre
            Configuracion.AddOrUpdateAppSettings("NombreBaseDatos", nombreBase);
            Configuracion.AddOrUpdateAppSettings("IsDbConfig", "true");
            
        }

        public static bool CrearBase(ConfigDbBEL configDbDatos)
        {
            var result =  Ejecutar(configDbDatos, "scriptDb") &&
                Ejecutar(configDbDatos, "scriptDbTables");

            if (result)
                ActualizarConectionString(configDbDatos.NombreBase);

            return result;
        }

        public static bool TestConexion(ConfigDbBEL datos)
        {
            string ConnectionStringTemplate = $"Data Source={datos.Servidor};Encrypt=False;"; //Basic part of the connection string
            string UserLogInTemplate = $"User={datos.Usuario};Password={datos.Password};";  //Template for adding user authentication
            string NoAuthString = "Integrated Security=true;"; //If no username/password provided use this

            connectionString = ConnectionStringTemplate;
                
            connectionString += !datos.UsarAutenticacionIntegrada 
                            ? UserLogInTemplate
                            : NoAuthString;

            var sqlcnn = new System.Data.SqlClient.SqlConnection(connectionString);
            
            try
            {
                sqlcnn.Open();
                return true;
            }
            catch (Exception ex)
            {
                datos.Mensaje = ex.Message;
                return false;
            }

        }


        
    }
}
