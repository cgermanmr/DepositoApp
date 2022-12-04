using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;
using AppDeposito.Test;
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
                if (e.KeyCode == Keys.F1 & !(sender as Form).IsMdiContainer) new AyudaForm().Show();
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


        //*********************//

        
        public static void ConfigurarForm(this Form form, bool enableEscKey = true, bool enterToTab = true, FormWindowState formWindowState = FormWindowState.Normal, bool fixedSize = false)
        {
            form.WindowState = formWindowState;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Visible = true;
            form.KeyPreview = true;
            form.MinimizeBox = false;
            form.ControlBox = true;

            if (fixedSize)
            {
                form.MinimumSize = form.Size;
                form.MaximumSize = form.Size;
                form.MaximizeBox = false;
            }

            if (formWindowState != FormWindowState.Maximized)
            {
                form.FormBorderStyle = FormBorderStyle.Sizable;
            }

            form.BackColor = System.Drawing.Color.LightBlue;

            if (enableEscKey)
            {
                form.KeyDown += (object sender, KeyEventArgs e) => {
                    if (e.KeyCode == Keys.Escape)
                        ((Form)sender).Close();
                };
            }

            form.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Down) //pasar de control con flecha
                    SendKeys.Send("{TAB}");

                if (e.KeyCode == Keys.Up) //pasar de control con flecha
                    SendKeys.Send("+{TAB}");
            };

            if (enterToTab)
            {
                EnterToTab(form);
            }
            //
            ForAllControls(form, control =>
            {
                if (control is NumericUpDown n)
                {
                    n.KeyPress += (sender, args) =>
                    {
                        if (args.KeyChar.Equals('.') || args.KeyChar.Equals(','))
                        {
                            args.KeyChar =
                                ((System.Globalization.CultureInfo)System.Globalization.CultureInfo.CurrentCulture)
                                .NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
                        }
                    };
                }
            });
        }

      
        public static bool ValidarNoTiraExcepcion(this ErrorProvider ep, Form ctrl)
        {
            ctrl.ValidateChildren();
            try
            {
                Validar(ep, ctrl);
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public static void ValidarCampoCompleto(this Control ctrl, ErrorProvider errprov, bool showMsjError = false, string msj = null, bool mantenerFoco = false)
        {
            ctrl.Validating += (object sender, System.ComponentModel.CancelEventArgs e) => {

                if (string.IsNullOrEmpty(ctrl.Text))
                {
                    string msjDefault = "Completar los datos";

                    errprov.SetError(ctrl, msj ?? msjDefault);

                    if (showMsjError)
                        MessageBox.Show(msj ?? msjDefault, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    e.Cancel = mantenerFoco;

                    return;
                }
                else
                    errprov.SetError(ctrl, "");
            };

        }

        public static void LimpiarErrores(this ErrorProvider ep, Control ctrl)
        {
            if (ctrl.Controls.Count > 0)
                foreach (Control c in ctrl.Controls)
                    LimpiarErrores(ep, c);

            if (ep.GetError(ctrl).Length > 0)
            {
                ep.SetError(ctrl, "");
            }
        }

        public static void ForAllControls(Control parent, Action<Control> action)
        {
            foreach (Control c in parent.Controls)
            {
                action(c);
                ForAllControls(c, action);
            }
        }

        private static void SoloNumerosConDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.WriteLine($"Caracter ingresado: {e.KeyChar}");

            Control ctrl = ((Control)sender);
            var separadorDecimal = CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];

            if (e.KeyChar == '.' | e.KeyChar == ',')
                e.KeyChar = separadorDecimal;

            if (e.KeyChar == '-')
            {
                var tb = sender as TextBox;

                if (tb.Text.Contains("-") & tb.SelectionLength != tb.Text.Length)
                    e.Handled = true;
                else
                {
                    if (tb.SelectionLength == tb.Text.Length)
                    {
                        e.Handled = false;
                        return;
                    }

                    tb.SelectionStart = 0;
                    tb.SelectionLength = 0;
                    e.Handled = false;
                }

                return;
            }


            if (e.KeyChar == separadorDecimal && ctrl.Text.IndexOf(separadorDecimal) > 0)
            {
                Debug.WriteLine($"Ya contiene separador - Se descarta");

                e.Handled = true;
                return;
            }

            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar) | e.KeyChar == '.' | e.KeyChar == ',')
            {
                Debug.WriteLine($"Es numero o separador");

                e.Handled = false;
            }
            else
            {
                Debug.WriteLine($"Caracter descartado");

                e.Handled = true;
            }

        }

        public static void SoloNumerosConDecimales(this Control control, int decimales = 2, int largo = 12)
        {
            if (control is TextBox box)
            {
                box.TextAlign = HorizontalAlignment.Right;
                box.Tag = decimales;
                box.MaxLength = largo;
            }
            control.KeyPress += SoloNumerosConDecimales_KeyPress;
            control.LostFocus += SoloNumerosConDecimales_LostFocus;
            control.TextChanged += SoloNumerosConDecimales_TextChanged;
        }

        private static void SoloNumerosConDecimales_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(((Control)sender).Tag.ToString(), out int cantidadDecimales);

            ((Control)sender).Text = string.Format(((Control)sender).Text, $"N{cantidadDecimales}");
        }

        private static void SoloNumerosConDecimales_LostFocus(object sender, EventArgs e)
        {
            string valor = ((Control)sender).Text;

            _ = int.TryParse(((Control)sender).Tag.ToString(), out int cantidadDecimales);
            cantidadDecimales = cantidadDecimales == 0 ? 2 : cantidadDecimales;

            decimal.TryParse(valor, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valorDecimal);

            ((Control)sender).Text = valorDecimal.ToString($"N{cantidadDecimales}");

        }

        private static void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) | Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static void SoloNumeros(this Control control, bool requerido = false, ErrorProvider ep = null, bool conSeperadorDeMiles = false)
        {
            if (control is TextBox box) box.TextAlign = HorizontalAlignment.Right;

            control.KeyPress += SoloNumeros_KeyPress;

            if (conSeperadorDeMiles)
                control.TextChanged += Control_TextChanged; // += Control_LostFocus; ;

            if (requerido)
                control.ValidarCampoRequerido(ep);
        }

        private static void Control_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(((TextBox)sender).Text, out decimal valor))
                return;

            TextBox textBox = ((TextBox)sender);

            textBox.Text = valor.ToString("N0", CultureInfo.CreateSpecificCulture("es-AR"));
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
        }

        private static void ValidarCampoRequerido(this Control ctrl, ErrorProvider ep = null)
        {
            ctrl.Validating += (object sender, CancelEventArgs e) => {


                if (string.IsNullOrEmpty(ctrl.Text))
                {
                    var msj = "Debe completar el campo";
                    //MessageBox.Show(msj, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (ep != null) ep.SetError(ctrl, msj);
                    //e.Cancel = true;
                    return;
                }

                if (ep != null) ep.SetError(ctrl, "");
            };

        }

       
        public static void SoloNumerosMaxMin(this Control control, int min, int max)
        {
            if (control is TextBox box) box.TextAlign = HorizontalAlignment.Right;
            control.KeyPress += SoloNumeros_KeyPress;
            control.Validating += (object sender, System.ComponentModel.CancelEventArgs e) =>
            {
                if (int.TryParse(control.Text, out int result))
                {
                    if (result > max | result < min)
                    {
                        MessageBox.Show($"El valor debe estar entre {min} y {max}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
            };
        }

        public static void SoloCaracteresHabilitados(this Control control, char[] caracteres)
        {
            if (control is TextBox box) box.Tag = caracteres;
            else return;
            control.KeyPress += SoloCaracteresHabilitados_KeyPress;
        }

        private static void SoloCaracteresHabilitados_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] caracteres = (char[])(sender as TextBox).Tag;
            if (Array.IndexOf(caracteres, e.KeyChar) != -1 | Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public static bool EsFechaValida(string fecha)
        {
            DateTime.TryParse(fecha, out DateTime _fecha);
            if (_fecha == DateTime.MinValue)
                return false;
            else
                return true;
        }

        public static bool ValidarMail(string mail)
        {
            try
            {
                MailAddress m = new MailAddress(mail);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #region OrdenarGrilla

        /// <summary>
        /// Agrega la funcionalidad de ordenar las columnas al clickear los titulos
        /// </summary>
        /// <typeparam name="T">Type de los elementos que muestra la grilla</typeparam>
        /// <param name="gv">Control DataGridView</param>
        /// <param name="bs">BindingSource de la grilla</param>
        public static void OrdenablePorColumnas<T>(this DataGridView gv, BindingSource bs)
        {
            //hago que todas las columnas sean ordenables
            for (int i = 0; i < gv.Columns.Count - 1; i++)
                gv.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;

            int _previousIndex = 0;
            bool _sortDirection = false;

            gv.ColumnHeaderMouseClick += (object sender, DataGridViewCellMouseEventArgs e) =>
            {

                var _grilla = (DataGridView)sender;

                if (e.ColumnIndex == _previousIndex)
                    _sortDirection ^= true; // toggle direction

                var column = _grilla.Columns[e.ColumnIndex].DataPropertyName;
                var list = bs.DataSource as List<T>;

                bs.DataSource = _sortDirection ? list.OrderBy(x => x.GetType()?.GetProperty(column)?.GetValue(x)).ToList() :
                                                list.OrderByDescending(x => x.GetType()?.GetProperty(column)?.GetValue(x)).ToList();

                _grilla.Columns[_previousIndex].HeaderCell.SortGlyphDirection = SortOrder.None;

                _grilla.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = _sortDirection ? SortOrder.Ascending : SortOrder.Descending;

                _previousIndex = e.ColumnIndex;
            };

        }


        #endregion

        #region EnumToCombo

        public static void BindEnumToComboBox<T>(this ComboBox comboBox, T defaultSelection)
        {
            var list = Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(value =>
                new
                {
                    Description = (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description ?? value.ToString(),
                    Value = value
                }
                )
                .OrderBy(item => item.Value.ToString())
                .ToList();

            comboBox.DataSource = list;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";

            foreach (var opts in list)
            {
                if (opts.Value.ToString() == defaultSelection.ToString())
                {
                    comboBox.SelectedItem = opts;
                }
            }
        }

        public static T ToEnum<T>(this string value)
        {
            if (value == null)
                return default;

            try
            {
                return (T)Enum.Parse(typeof(T), value, true);
            }
            catch (Exception)
            {
                return default;
            }
        }

        #endregion



        //***************************//




    }
}
