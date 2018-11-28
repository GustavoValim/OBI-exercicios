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
    public partial class formTelaPrincipal : Form
    {
        public formTelaPrincipal()
        {
            InitializeComponent();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formVendas f = new formVendas();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formCadastroCliente f = new formCadastroCliente();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formVerificarCliente f = new formVerificarCliente();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // formCadastroProduto f = new formCadastroProduto();
            //f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formEstoque f = new formEstoque();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formTemporada f = new formTemporada();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formConsulta f = new formConsulta();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formDataPagamento f = new formDataPagamento();
            f.ShowDialog();
        }

        private void formTelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
