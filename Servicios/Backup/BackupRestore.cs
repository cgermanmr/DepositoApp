using System.Collections.Generic;
using System;
using BEL;
using DAL;
using Interfaces;

namespace Servicios
{
    public class BackupRestore
    {
        public List<BackupBEL> Listar()
        {
            return new BackupRestoreDAL().Listar();
        }

        public bool RealizarBackup(string ubicacion)
        {
            new BackupRestoreDAL().RealizarBackup(ubicacion);
            return new BackupRestoreDAL().Agregar(new BackupBEL() { Ubicacion= ubicacion,Usuario = Sesion.SesionActual().ObtenerUsuarioActual.Nombre});

        }

        public bool RealizarRestore(string ubicacion)
        {
            return new BackupRestoreDAL().RealizarRestore(ubicacion);
        }
    }
}
