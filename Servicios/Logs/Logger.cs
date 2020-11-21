using System.Diagnostics;
using System;

namespace Servicios
{


    // http://www.codeproject.com/Articles/15291/Error-and-Event-Logging-in-VB-NET

    public class Logger
    {
        public static bool WriteLog(string entry, string stkTrace = "Evento Auditado", EventLogEntryType eventType = EventLogEntryType.Information)
        {

            // Registrar en EventLog
            EventLogger.WriteToEventLog(entry, stkTrace, eventType);

            // Registrar en Archivo de Log
            TextLogger.WriteToTextLog(entry, stkTrace, eventType.ToString());

            return true;
        }

        public static bool WriteLogExeption(Exception ex, int idSuseso = 0)
        {              
            
            // Registrar en EventLog
            EventLogger.WriteToEventLog(ex.Message, ex.StackTrace, EventLogEntryType.Error, idSuseso);

            // Registrar en Archivo de Log
            TextLogger.WriteToTextLog(ex.Message, ex.StackTrace, EventLogEntryType.Error.ToString(), idSuseso);
            
            return true;
        }
    }
}
