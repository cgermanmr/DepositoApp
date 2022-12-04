using System.Data;
using System.Collections.Generic;
using System;
using BEL;
using System.Collections;
using Comun;
using System.Diagnostics.Eventing.Reader;
using System.Configuration;
using System.IO;
//using Microsoft.SqlServer.Management.Smo;

namespace DAL
{
    public class BackupRestoreDAL
    {
        public List<BackupBEL> Listar()
        {
            var datos = new Datos();
            var hdatos = new Hashtable();

            hdatos.Add("@operacion", 4);
            DataSet ds = datos.Leer("SP_BACkUP",hdatos);
            List<BackupBEL> bkps = new List<BackupBEL>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                bkps.Add(DataRowToEntidad(dr));
            }
            return bkps;
        }

        public bool Agregar(BackupBEL backup) 
        {
            var datos = new Datos();
            var hdatos = new Hashtable();
            bool resultado;

            hdatos.Add("@operacion", 1);
            hdatos.Add("@UBICACION", backup.Ubicacion);
            hdatos.Add("@USUARIO", backup.Usuario);
            

            resultado = datos.Escribir("SP_BACKUP", hdatos);

            return resultado;

        }

        private BackupBEL DataRowToEntidad(DataRow dr)
        {
            var bkp = new BackupBEL();
            bkp.Id = (int)dr["COD_BACKUP"];
            bkp.Usuario = dr["COD_USUARIO"].ToString();
            bkp.Ubicacion = dr["UBICACION"].ToString();
            bkp.Fecha = dr["FECHA"].SafeToDateTime();

            return bkp;
        }

        public bool RealizarBackup(string ubicacion)
        {
            var datos = new Datos();
            var nombreBase = Configuracion.TryGetValueFromAppSettings("NombreBaseDatos");
            return datos.Ejecutar(string.Format($"BACKUP DATABASE [{nombreBase}] TO  DISK = N'{0}' WITH NOFORMAT, NOINIT,  NAME = N'Deposito-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", ubicacion));
        }
        public bool RealizarRestore(string ubicacion)
        {
            var datos = new Datos();
            var nombreBase = Configuracion.TryGetValueFromAppSettings("NombreBaseDatos");
            return datos.Ejecutar($@"USE [master]
                ALTER DATABASE [{nombreBase}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
                RESTORE DATABASE [{nombreBase}] FROM  DISK = N'{Path.Combine(ubicacion)}' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5
                ALTER DATABASE [{nombreBase}] SET MULTI_USER
                USE [{nombreBase}]");
        }

       


    }
}
