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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            formCadastroCliente fCadastroCliente = new formCadastroCliente();
            fCadastroCliente.MdiParent = this;
            fCadastroCliente.Show();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCadastroProduto f = new formCadastroProduto();
            f.MdiParent = this;
            f.Show();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVendas f = new formVendas();
            f.MdiParent = this;
            f.Show();
        }

        private void procurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVerificarCliente f = new formVerificarCliente();
            f.MdiParent = this;
            f.Show();
        }

        private void procurarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formEstoque f = new formEstoque();
            f.MdiParent = this;
            f.Show();
        }

        private void verificarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsulta f = new formConsulta();
            f.MdiParent = this;
            f.Show();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGerarPedido f = new formGerarPedido();
            f.MdiParent = this;
            f.Show();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDataPagamento f = new formDataPagamento();
            f.MdiParent = this;
            f.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
