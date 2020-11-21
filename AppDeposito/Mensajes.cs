using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDeposito
{
   public static class Mensajes
    {
        public static void MensajeResultado(bool resultado, Form contexto)
        {
            if (resultado)
                MessageBox.Show("La operación a concluído exitosamente.", contexto.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se ha podido realizar la operación", contexto.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensajeExcepcion(Exception ex, Form contexto)
        {
            Servicios.Logger.WriteLogExeption(ex);
            if (ex.GetType()==typeof(InvalidOperationException))
                MessageBox.Show($"No se puede realizar la operación: \n\n {ex.Message} ", contexto.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show($"Se ha producido un error: \n\n {ex.Message} ", contexto.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
