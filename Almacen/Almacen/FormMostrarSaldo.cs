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
    public partial class FormMostrarSaldo : Form
    {
        public FormMostrarSaldo()
        {
            InitializeComponent();
        }

        private void FormMostrarSaldo_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = "$ " + MenuAdmin.miCaja.Dinero;
        }
    }
}
