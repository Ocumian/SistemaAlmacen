﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen
{
    public partial class MenuAdmin : Form
    {
        //private int childFormNumber = 0;
        Form ventanaAbierta = null;

        public static Caja miCaja;
        public static Bodega miBodega;

        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            MenuAdmin.miCaja = new Caja();
            MenuAdmin.miBodega = new Bodega();
        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Ventana " + childFormNumber++;
        //    childForm.Show();
        //}

        //private void OpenFile(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = saveFileDialog.FileName;
        //    }
        //}

        //private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //}

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        //private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.Cascade);
        //}

        //private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.TileVertical);
        //}

        //private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.TileHorizontal);
        //}

        //private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.ArrangeIcons);
        //}

        //private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (Form childForm in MdiChildren)
        //    {
        //        childForm.Close();
        //    }
        //}

        private void ingresarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            FormIngresarDinero ventanaChild = new FormIngresarDinero();
            ventanaChild.MdiParent = this;
            ventanaChild.Dock = DockStyle.Fill;
            ventanaChild.Show();
            ventanaAbierta = ventanaChild;
        }

        private void sacarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            FormSacarDinero ventanaChild = new FormSacarDinero();
            ventanaChild.MdiParent = this;
            ventanaChild.Dock = DockStyle.Fill;
            ventanaChild.Show();
            ventanaAbierta = ventanaChild;
        }

        private void mostrarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            FormMostrarSaldo ventanaChild = new FormMostrarSaldo();
            ventanaChild.MdiParent = this;
            ventanaChild.Dock = DockStyle.Fill;
            ventanaChild.Show();
            ventanaAbierta = ventanaChild;
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            FormComprarProd ventanaChild = new FormComprarProd();
            ventanaChild.MdiParent = this;
            ventanaChild.Dock = DockStyle.Fill;
            ventanaChild.Show();
            ventanaAbierta = ventanaChild;
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            FormVenderProd ventanaChild = new FormVenderProd();
            ventanaChild.MdiParent = this;
            ventanaChild.Dock = DockStyle.Fill;
            ventanaChild.Show();
            ventanaAbierta = ventanaChild;
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            FormStock ventanaChild = new FormStock();
            ventanaChild.MdiParent = this;
            ventanaChild.Dock = DockStyle.Fill;
            ventanaChild.Show();
            ventanaAbierta = ventanaChild;
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventanaAbierta != null)
            {
                ventanaAbierta.Close();
            }
            FormMostrarInventario ventanaChild = new FormMostrarInventario();
            ventanaChild.MdiParent = this;
            ventanaChild.Dock = DockStyle.Fill;
            ventanaChild.Show();
            ventanaAbierta = ventanaChild;
        }

    }
}
