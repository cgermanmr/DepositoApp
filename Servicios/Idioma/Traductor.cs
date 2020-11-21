using System;
using System.ComponentModel;
using System.Windows.Forms;
using BEL;

namespace Servicios
{
    public class Traductor
    {
        private static Idioma idioma = new Idioma();
        public static void RegistrarLeyendas(object ctrl)
        {
            //Idioma idioma = new Idioma();
            if (ctrl is TextBox) return;
            //Registra items del menu
            if (ctrl is ToolStripDropDownItem)
            {
                if (!string.IsNullOrEmpty(((ToolStripDropDownItem)ctrl).Text))
                {
                    idioma.RegistrarLeyenda(new LeyendaBEL() { Codigo = ((ToolStripDropDownItem)ctrl).Text });
                    ((ToolStripDropDownItem)ctrl).Tag = ((ToolStripDropDownItem)ctrl).Text;
                }
                foreach (var item in ((ToolStripDropDownItem)ctrl).DropDownItems)
                    RegistrarLeyendas(item);
            }

            //Registrar controles
            if (ctrl is Control)
            {
                if (!string.IsNullOrEmpty(((Control)ctrl).Text))
                {
                    ((Control)ctrl).Tag = ((Control)ctrl).Text;
                    idioma.RegistrarLeyenda(new LeyendaBEL() { Codigo = ((Control)ctrl).Text });
                }
                foreach (Control item in ((Control)ctrl).Controls)
                {
                    if (item is MenuStrip)
                    {
                        foreach (var menu in ((MenuStrip)item).Items)
                            RegistrarLeyendas(menu);
                    }
                    else if (item is DataGridView)
                    {
                        foreach (DataGridViewColumn column in ((DataGridView)item).Columns)
                        {
                            if (!string.IsNullOrEmpty(column.HeaderText))
                            {
                                column.Tag = column.HeaderText;
                                idioma.RegistrarLeyenda(new LeyendaBEL() { Codigo = column.HeaderText });
                            }                                                                                                        
                        }           
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(item.Text))
                        {
                            item.Tag = item.Text;
                            idioma.RegistrarLeyenda(new LeyendaBEL() { Codigo = item.Text });
                        }
                    }
                    
                }
            }
        }

        public static void Traducir(object ctrl)
        {
            if (ctrl is TextBox) return;

            IdiomaBEL idioma = Sesion.SesionActual().IdiomaActual;

            //Registra items del menu
            if (ctrl is ToolStripDropDownItem)
            {
                if (!string.IsNullOrEmpty(((ToolStripDropDownItem)ctrl).Text))
                {
                    ((ToolStripDropDownItem)ctrl).Text = idioma.Leyendas.Find(x => x.Codigo == ((ToolStripDropDownItem)ctrl).Tag.ToString()).Valor;
                }
                foreach (var item in ((ToolStripDropDownItem)ctrl).DropDownItems)
                    Traducir(item);
            }

            //Registrar controles
            if (ctrl is Control)
            {
                if (!string.IsNullOrEmpty(((Control)ctrl).Text))
                {
                    ((Control)ctrl).Text = idioma.Leyendas.Find(x => x.Codigo == ((Control)ctrl).Tag.ToString()).Valor;
                }
                foreach (Control item in ((Control)ctrl).Controls)
                {
                    if (item is MenuStrip)
                    {
                        foreach (var menu in ((MenuStrip)item).Items)
                            Traducir(menu);
                    }
                    else if (item is DataGridView)
                    {
                        foreach (DataGridViewColumn column in ((DataGridView)item).Columns)
                        {
                            if (!string.IsNullOrEmpty(column.HeaderText))
                            {
                                column.HeaderText=idioma.Leyendas.Find(x=>x.Codigo == column.Tag.ToString()).Valor;
                            }
                        }
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(item.Text) && item.Tag!=null)
                        {   
                            item.Text = idioma.Leyendas.Find(x => x.Codigo == item.Tag.ToString()).Valor;
                        }
                    }
                }
            }
        }
    }
}
