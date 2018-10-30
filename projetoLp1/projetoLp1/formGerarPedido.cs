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
    public partial class formGerarPedido : Form
    {
        public formGerarPedido()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manda para o datagrid");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("gera arquivo <data_entrega>.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exclui item do datagrid");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Retorna informações para os txtBox para edição");
        }
    }
}
