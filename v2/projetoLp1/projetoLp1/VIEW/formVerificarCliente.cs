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
            this.WindowState = FormWindowState.Maximized;            
        }

        public void atualizarTabela()
        {
            dataGridView1.Rows.Clear();
            DAOcliente DAO = new DAOcliente();
            List<Cliente> lista = new List<Cliente>();
            lista = DAO.listaClientes();

            //preenche o datagrid
            foreach (Cliente c in lista)
                dataGridView1.Rows.Add(c.Codigo, c.Nome, c.Estado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (i > -1)
            {
                formCadastroCliente f = new formCadastroCliente(false, i);
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                MessageBox.Show("SELECIONE UMA LINHA");
            }
        }

        private void formVerificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //verifica datagrid
            int i = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (i > -1)
            {
                formCadastroCliente f = new formCadastroCliente(true, i);
                f.MdiParent = this.MdiParent;
                f.Show();
            }
            else
            {
                MessageBox.Show("SELECIONE UMA LINHA");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int i = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (i > -1)
            {
                DAOcliente dao = new DAOcliente();
                dao.remover(i);
                atualizarTabela();
            }
        }

        private void formVerificarCliente_Activated(object sender, EventArgs e)
        {           
            atualizarTabela();
        }
    }
}
