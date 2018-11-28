using System;
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
    public partial class formConsulta : Form
    {
        public formConsulta()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gera arquivo <cliente_data_compra>");
            this.Close();
        }

        private void formConsulta_Load(object sender, EventArgs e)
        {

        }
    }
}
