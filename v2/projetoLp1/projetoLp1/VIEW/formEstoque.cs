﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLp1
{
    public partial class formEstoque : Form
    {
        public formEstoque()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salva no banco");
            this.Close();
        }

        private void formEstoque_Load(object sender, EventArgs e)
        {

        }
    }
}
