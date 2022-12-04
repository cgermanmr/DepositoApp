using System;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;
using BEL;

namespace Servicios
{
    public class Traductor
    {
        private static Idioma idioma = new Idioma();
        public static void RegistrarLeyendas(object ctrl)
        {
            if (ctrl is TextBox) return;
            if (ctrl is ComboBox) return;
            if (ctrl is DateTimePicker) return;
            //Registra items del menu
            if (ctrl is ToolStripDropDownItem ts)
            {
                if (!string.IsNullOrEmpty(ts.Text))
                {
                    idioma.RegistrarLeyenda(new LeyendaBEL() { Codigo = ts.Text });
                    ts.Tag ??= ts.Text;
                }
                foreach (var item in ts.DropDownItems)
                    RegistrarLeyendas(item);
            }

            //Registrar controles
            if (ctrl is Control c)
            {
                if (!string.IsNullOrEmpty(c.Text))
                {
                    c.Tag ??= c.Text;

                    idioma.RegistrarLeyenda(new LeyendaBEL() { Codigo = c.Text });
                }

                foreach (Control item in c.Controls)
                {
                    if (item is MenuStrip menuStrip)
                    {
                        foreach (var menu in menuStrip.Items)
                            RegistrarLeyendas(menu);
                    }
                    
                    if (item is DataGridView gridView)
                    {
                        foreach (DataGridViewColumn column in gridView.Columns)
                        {
                            if (!string.IsNullOrEmpty(column.HeaderText))
                            {
                                column.Tag ??= column.HeaderText;

                                idioma.RegistrarLeyenda(new LeyendaBEL() { Codigo = column.HeaderText });
                            }                                                                                                        
                        }           
                    }

                    if (!string.IsNullOrEmpty(item.Text))
                        RegistrarLeyendas(item);

                    if (item is Panel panel)
                    {
                        foreach (Control f in panel.Controls)
                            RegistrarLeyendas(f);
                    }

                }

            }
        
        }

        public static void Traducir(object ctrl)
        {
            if (ctrl is TextBox) return;
            if (ctrl is ComboBox) return;
            if (ctrl is DateTimePicker) return;

            IdiomaBEL idioma = Sesion.SesionActual().IdiomaActual;

            //Traducir items del menu
            if (ctrl is ToolStripDropDownItem ts)
            {
                if (!string.IsNullOrEmpty(ts.Text))
                {
                    ts.Text = idioma.Leyendas.Find(x => x.Codigo.Trim().ToLower() == ts.Tag.ToString().Trim().ToLower()).Valor;
                }
                foreach (var item in ts.DropDownItems)
                    Traducir(item);
            }

            //Traducir controles
            if (ctrl is Control c)
            {
                if (!string.IsNullOrEmpty(c.Text))
                {
                    var leyenda = idioma.Leyendas
                        .FirstOrDefault(x => 
                        x.Codigo.Trim().ToLower() == c.Tag.ToString().Trim().ToLower());

                    c.Text = leyenda == null
                            ? c.Text
                            : leyenda.Valor;
                }

                foreach (Control item in c.Controls)
                {
                    if (item is MenuStrip menuStrip)
                    {
                        foreach (var menu in menuStrip.Items)
                            Traducir(menu);
                    }

                    if (item is DataGridView dataGrid)
                    {
                        foreach (DataGridViewColumn column in dataGrid.Columns)
                        {
                            if (!string.IsNullOrEmpty(column.HeaderText))
                                column.HeaderText = idioma.Leyendas.Find(x => x.Codigo.Trim().ToLower() == column.Tag.ToString().Trim().ToLower()).Valor;
                        }
                    }

                    if (item.Text.Length>0 && item.Tag != null)
                        Traducir(item);

                    if (item is Panel panel)
                    {
                        foreach (Control f in panel.Controls)
                            Traducir(f);
                    }

                }
            }

    
        }


    }
}
