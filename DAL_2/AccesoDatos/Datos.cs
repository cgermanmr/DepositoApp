using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Datos
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DepositoDB"].ConnectionString);
        private SqlTransaction trx;
        private SqlCommand cmd;

        public DataSet Leer(string consulta, Hashtable hdatos)
        {
            var DS = new DataSet();
            cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = consulta,
                CommandType = CommandType.StoredProcedure
            };

            if (hdatos != null)
            {
                //si la hashtable no esta vacia, y tiene el dato q busco 
                foreach (string dato in hdatos.Keys)
                {
                    //cargo los parametros que le estoy pasando con la Hash
                    cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                }
            }

            var Adaptador = new SqlDataAdapter(cmd);

            Adaptador.Fill(DS);
            return DS;
        }

        public bool Escribir(string consulta, Hashtable hdatos)
        {

            if (connection.State == ConnectionState.Closed)
                connection.Open();

            try
            {
                trx = connection.BeginTransaction();
                cmd = new SqlCommand
                {
                    Connection = connection,
                    CommandText = consulta,
                    CommandType = CommandType.StoredProcedure,
                    Transaction = trx
                };

                if (hdatos != null)
                {
                    foreach (string dato in hdatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        cmd.Parameters.AddWithValue(dato, hdatos[dato]);
                    }
                }

                Int32 respuesta = cmd.ExecuteNonQuery();
                trx.Commit();

                return respuesta>=0;
            }
            catch (Exception ex)
            {
                trx.Rollback();
                //return false;
                
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Ejecutar(string consulta)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();

            cmd = new SqlCommand
            {
                Connection = connection,
                CommandText = consulta,
                CommandType = CommandType.Text
            };

            Int32 respuesta = cmd.ExecuteNonQuery();

            return respuesta > 0;
        }

        private static SqlCommand ObtenerComando(string SelectCommand, SqlConnection Conexion)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = SelectCommand;
            comando.CommandType = CommandType.Text;
            comando.Connection = Conexion;
            return comando;
        }
                     
        public static DataTable ObtenerDataTable(string SelectCommand)
        {
            SqlDataAdapter da = new SqlDataAdapter(ObtenerComando(SelectCommand, connection));
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
        public static int Actualizar(string SelectCommand, DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(ObtenerComando(SelectCommand, connection));
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.InsertCommand = cb.GetInsertCommand();
            da.DeleteCommand = cb.GetDeleteCommand();
            da.UpdateCommand = cb.GetUpdateCommand();

            return da.Update(dt);
        }                      
    }
}
