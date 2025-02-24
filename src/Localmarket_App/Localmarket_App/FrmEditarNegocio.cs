﻿using Localmarket_App.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Localmarket_App
{
    public partial class FrmEditarNegocio : Form
    {
        private bool modoNoche;

        public FrmEditarNegocio(bool modoNoche)
        {
            InitializeComponent();
            this.modoNoche = modoNoche;

        }

        private void FrmPerfilEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void picAjustes_Click(object sender, EventArgs e)
        {
            if (pnlAjustes.Visible == false)
            {
                pnlAjustes.Visible = true;
            }
            else if (pnlAjustes.Visible == true)
            {
                pnlAjustes.Visible = false;
            }
        }

        private void picNocheOn_Click(object sender, EventArgs e)
        {
            modoNocheOff();
        }

        private void picNocheOff_Click(object sender, EventArgs e)
        {
            modoNocheOn();
        }

        private void modoNocheOn()
        {
            picNocheOff.Visible = false;
            picNocheOn.Visible = true;
            modoNoche = true;
            pnlNaranja.BackColor = Color.Black;
            pnlAjustes.BackColor = Color.DarkCyan;
            picAjustes.Image = Resources.ajustesicono;
            picAtras.Image = Resources.flechaatrasblanca;
            this.BackColor = Color.DimGray;

            foreach (GroupBox g in Controls.OfType<GroupBox>())
                foreach (Label l in g.Controls.OfType<Label>())
                {
                    l.ForeColor = Color.White;
                }
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.White;
            }
        }

        private void modoNocheOff()
        {
            picNocheOff.Visible = true;
            picNocheOn.Visible = false;
            modoNoche = false;
            pnlNaranja.BackColor = Color.Orange;
            pnlAjustes.BackColor = Color.Aqua;
            picAjustes.Image = Resources.icono_ajustes;
            picAtras.Image = Resources.flechaatras;
            this.BackColor = Color.FromKnownColor(KnownColor.Control);

            foreach (GroupBox g in Controls.OfType<GroupBox>())
                foreach (Label l in g.Controls.OfType<Label>())
                {
                    l.ForeColor = Color.Black;
                }
            foreach (Label l in Controls.OfType<Label>())
            {
                l.ForeColor = Color.Black;
            }
        }

        private void btnElegirLogo_Click(object sender, EventArgs e)
        {
            if (openFileDialogLogoNegocio.ShowDialog() == DialogResult.OK)
            {
                picPreviewLogo.Image = new Bitmap(openFileDialogLogoNegocio.FileName);
            }
        }

        private void picImagen1_Click(object sender, EventArgs e)
        {
            if (openFileDialogImagen1.ShowDialog() == DialogResult.OK)
            {
                picImagen1.Image = new Bitmap(openFileDialogImagen1.FileName);
            }
        }

        private void picImagen2_Click(object sender, EventArgs e)
        {
            if (openFileDialogImagen2.ShowDialog() == DialogResult.OK)
            {
                picImagen2.Image = new Bitmap(openFileDialogImagen2.FileName);
            }
        }

        private void picImagen3_Click(object sender, EventArgs e)
        {
            if (openFileDialogImagen3.ShowDialog() == DialogResult.OK)
            {
                picImagen3.Image = new Bitmap(openFileDialogImagen3.FileName);
            }
        }

        private void picImagen4_Click(object sender, EventArgs e)
        {
            if (openFileDialogImagen4.ShowDialog() == DialogResult.OK)
            {
                picImagen4.Image = new Bitmap(openFileDialogImagen4.FileName);
            }
        }

        private void btnElegirFotoProducto_Click(object sender, EventArgs e)
        {
            if (openFileDialogImagenProducto.ShowDialog() == DialogResult.OK)
            {
                picPreviewProducto.Image = new Bitmap(openFileDialogImagenProducto.FileName);
            }
        }

        private void picAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picNuevoProducto_Click(object sender, EventArgs e)
        {
            grpBoxAñadirProducto.Visible = true;
        }
    }
}
