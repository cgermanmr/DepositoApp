using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using Servicios;

namespace AppDeposito
{
    public static class FormConfig
    {
        public static void TextBoxToReadOnly(object ctx)
        {            
                foreach (var item in ((Control)ctx).Controls)
                {
                    if (((Control)item).Controls.Count > 0) TextBoxToReadOnly(item);

                    if (item is TextBox)
                        ((TextBox)item).ReadOnly = true;    

                }
        }

        private static void EnterToTab(Control control)
        {
            if (control == null) return;

            foreach (Control item in control.Controls)
            {
                if (item.Controls.Count > 0)
                    EnterToTab(item);

                if (item is TextBox | item is MaskedTextBox)
                {
                    item.KeyDown += (object sdr, KeyEventArgs ev) =>
                    {
                        if (ev.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
                    };
                    item.GotFocus += (object sdr, EventArgs ev) =>
                    {
                        if (item is MaskedTextBox) ((MaskedTextBox)item).SelectAll();
                        if (item is TextBox) ((TextBox)item).SelectAll();
                    };
                }

            }
        }
        public static void Config(Form form)
        {
            if(form is IObserverTraducible)
                Sesion.SesionActual().Suscribir((IObserverTraducible)form);

            form.KeyPreview = true;
            //form.ControlBox = false;
            form.WindowState = FormWindowState.Normal;
            form.KeyDown += (object sender, KeyEventArgs e) => {
                if (e.KeyCode == Keys.Escape) ((Form)sender).Close();
            };
        }

        public static void Validar(ErrorProvider ep, Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c.Controls.Count > 0)
                    Validar(ep, c);

                if (ep.GetError(c).Length > 0)
                {
                    throw new InvalidOperationException(ep.GetError(c));
                }
            }
        }

        public static void LimpiarCombos(Control ctx)
        {
            foreach (var item in ctx.Controls)
                if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
        }

        public static void ValidarCamposCompletos(Control ctx, ErrorProvider ep)
        {
            foreach (Control item in ctx.Controls)
            {
                if (item.Text == "")
                    ep.SetError(item, "Completar el campo"); 
                else
                    ep.SetError(item, "");
            }
            Validar(ep,ctx);
        }
    }
}
