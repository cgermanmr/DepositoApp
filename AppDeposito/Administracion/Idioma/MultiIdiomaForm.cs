﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using Servicios;
using Interfaces;

namespace AppDeposito.Administracion.Idioma
{
    public partial class MultiIdiomaForm : Form,IObserverTraducible
    {         
        public MultiIdiomaForm()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var nuevoIdioma = new IdiomaBEL();
            nuevoIdioma.Leyendas = new Servicios.Idioma().Listar().Find(x => x.Nombre == "Predeterminado").Leyendas;
            new EdicionIdiomaForm() { Editado = nuevoIdioma }.ShowDialog();
            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            bsIdiomas.DataSource = new Servicios.Idioma().Listar();             
        }

        private BindingSource bsIdiomas=new BindingSource();

        private void EnlazarControles()
        {
            cmbIdioma.DataSource = bsIdiomas;
            txtDescripcion.DataBindings.Add("Text", bsIdiomas, "Descripcion");
        }

        private void MultiIdiomaForm_Load(object sender, EventArgs e)
        {   
            Sesion.SesionActual().Suscribir(this);
            ObtenerDatos();
            EnlazarControles();   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            new EdicionIdiomaForm() { Editado = (IdiomaBEL)cmbIdioma.SelectedItem }.ShowDialog();
            ObtenerDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Sesion.SesionActual().IdiomaActual = (IdiomaBEL)bsIdiomas.Current;
        }

        private void MensajeResultado(bool resultado)
        {
            if (resultado)
                MessageBox.Show("La operación a concluído exitosamente.", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se ha podido realizar la operación", "Operación no realizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar idioma " + ((IdiomaBEL)bsIdiomas.Current).Nombre,"Eliminar idioma",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
               MensajeResultado(new Servicios.Idioma().Eliminar((IdiomaBEL)bsIdiomas.Current));

            ObtenerDatos();
        }

        public void Traducir()
        {
            Traductor.Traducir(this);
        }
    }
}
