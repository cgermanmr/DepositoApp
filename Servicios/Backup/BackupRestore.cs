using System.Collections.Generic;
using System;
using BEL;
using DAL;

namespace Servicios
{
    public class BackupRestore
    {           
        public bool RealizarBackup(string ubicacion)
        {
            try
            {
                return new BackupRestoreDAL().RealizarBackup(ubicacion);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                throw ex;
            }
        }

        public bool RealizarRestore(string ubicacion)
        {
            try
            {
                return new BackupRestoreDAL().RealizarRestore(ubicacion);
            }
            catch (Exception ex)
            {
                // REGISTRAR EN BITACORA
                throw ex;
            }
        }
    }
}
