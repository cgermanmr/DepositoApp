using System.Diagnostics;
using System;

namespace Servicios
{
    [CLSCompliant(true)]
    public class EventLogger
    {
        public EventLogger()
        {
        }

        public static bool WriteToEventLog(string entry, string stkTrace, EventLogEntryType eventType = EventLogEntryType.Information, int idSuseso = 0, string appName = "iDeposito", string logName = "iDeposito Logs")
        {
            try
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.WriteEntry(entry, EventLogEntryType.Error);
                }

                if (!EventLog.SourceExists("Deposito"))
                // Registrar su applicación de demostración como un origen de suceso.
                EventLog.CreateEventSource("Deposito", "Deposito Logs");

                // Crear un objeto EventLog conectado a este registro de sucesos.
                EventLog evLog = new EventLog("Deposito Logs", ".", "Deposito");

                // Escribir dos entradas al registro de aplicaciones.
                evLog.WriteEntry(entry, eventType, idSuseso);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
