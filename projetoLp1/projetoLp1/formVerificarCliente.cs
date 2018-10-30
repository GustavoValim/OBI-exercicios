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
    public partial class formVerificarCliente : Form
    {
        public formVerificarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formCadastroCliente f = new formCadastroCliente();
            f.Text = "Editar cliente";
            f.ShowDialog();
        }
    }
}
