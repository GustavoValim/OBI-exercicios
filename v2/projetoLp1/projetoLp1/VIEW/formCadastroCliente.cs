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
    public partial class formCadastroCliente : Form
    {

        private int aux;
        public formCadastroCliente()
        {            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        

        public formCadastroCliente(bool modo, int i)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            aux = i;

            Cliente c;
            DAOcliente DAO = new DAOcliente();

            c = DAO.dadosCliente(i); 

            if(modo) //modo visualizar
            {
                somenteLeitura();
                preencherTextBox(c);
                btnSalvar.Text = "Fechar";                
            }
            else
            {                
                DAOcliente dao = new DAOcliente();               
                c = dao.dadosCliente(i);                
                preencherTextBox(c);
                btnSalvar.Text = "Editar";              
            }            
        }




        public void preencherTextBox(Cliente c)
        {
            txtNome.Text = c.Nome;
            txtNomeRua.Text = c.NomeRua;
            txtNumero.Text = c.NroRua;
            txtBairro.Text = c.Bairro;
            txtTelefone.Text = c.Telefone;
            txtComplemento.Text = c.Complemento;
        }

        public void somenteLeitura()
        {
            txtNome.ReadOnly = true;
            txtNomeRua.ReadOnly = true;
            txtNumero.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtComplemento.ReadOnly = true;
        }

        public void limparCampos()
        {
            txtNome.Text = "";
            txtNomeRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtTelefone.Text = "";
            txtComplemento.Text = "";
        }

        public Cliente preencherClasse()
        {
            Cliente c = new Cliente(txtNome.Text, txtNomeRua.Text, txtNumero.Text, txtBairro.Text, txtTelefone.Text, txtComplemento.Text);
            return c;
        }        

        private void button1_Click(object sender, EventArgs e)
        {

            if (btnSalvar.Text == "Salvar")
            { 
                //guarda dados do textbox no objeto Cliente
                Cliente c = preencherClasse();
                DAOcliente DAO = new DAOcliente();
                DAO.salvar(c); 
                this.Close();
            }
            else if (btnSalvar.Text == "Fechar")
                this.Close();
            else if(btnSalvar.Text == "Editar")
            {
                //guarda dados do textbox no objeto Cliente
                Cliente c = preencherClasse();
                c.Codigo = aux;
                DAOcliente DAO = new DAOcliente();              
                DAO.atualizar(c);                
                this.Close();
            }
        }

        private void formCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
