using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace Servicios
{

    // <CLSCompliant(True)> _
    public class TextLogger
    {
        public TextLogger()
        {
        }


        // *************************************************************
        // NAME:          WriteToErrorLog
        // PURPOSE:       Open or create an error log and submit error message
        // PARAMETERS:    msg - message to be written to error file
        // stkTrace - stack trace from error message
        // title - title of the error file entry
        // RETURNS:       Nothing
        // *************************************************************
        public static void WriteToTextLog(string msg, string stkTrace, string title, int idSuseso = 0)
        {

            // check and make the directory if necessary; this is set to look in the application
            // folder, you may wish to place the error log in another location depending upon the
            // the user's role and write access to different areas of the file system
            if (!Directory.Exists(Application.StartupPath + @"\logs\"))
                Directory.CreateDirectory(Application.StartupPath + @"\logs\");

            // check the file
            FileStream fs = new FileStream(Application.StartupPath + @"\logs\logs.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter s = new StreamWriter(fs);
            s.Close();
            fs.Close();

            // log it
            FileStream fs1 = new FileStream(Application.StartupPath + @"\logs\logs.txt", FileMode.Append, FileAccess.Write);
            StreamWriter s1 = new StreamWriter(fs1);
            s1.Write("Title: " + title + Environment.NewLine);
            s1.Write("Id: " + idSuseso + Environment.NewLine);
            s1.Write("Message: " + msg + Environment.NewLine);
            s1.Write("StackTrace: " + stkTrace + Environment.NewLine);
            s1.Write("Date/Time: " + DateTime.Now.ToString() + Environment.NewLine);
            s1.Write("===========================================================================================" + Environment.NewLine);
            s1.Close();
            fs1.Close();
        }
    }
}
