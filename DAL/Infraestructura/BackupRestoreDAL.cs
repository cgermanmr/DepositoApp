using System.Data;
using System.Collections.Generic;
using System;
using BEL;
using System.Collections;

namespace DAL
{
    public class BackupRestoreDAL
    {
        public bool RealizarBackup(string ubicacion)
        {
            var datos = new Datos();
            return datos.Ejecutar(string.Format("BACKUP DATABASE [Deposito] TO  DISK = N'{0}' WITH NOFORMAT, NOINIT,  NAME = N'Deposito-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", ubicacion));
        }
        public bool RealizarRestore(string ubicacion)
        {
            var datos = new Datos();
            return datos.Ejecutar(string.Format("USE [master]; RESTORE DATABASE[Deposito] FROM DISK = N'{0}' WITH FILE = 1, NOUNLOAD, REPLACE, STATS = 5", ubicacion));
        }

    }
}
