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
    public partial class formCadastroProduto : Form
    {
        public formCadastroProduto()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
    

    private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salva no banco");
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
