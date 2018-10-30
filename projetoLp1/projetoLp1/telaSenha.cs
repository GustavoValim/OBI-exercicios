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
    public partial class telaSenha : Form
    {
        public telaSenha()
        {
            InitializeComponent();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void btn_configurar_Click(object sender, EventArgs e)
        {
            formConfiguracao f = new formConfiguracao();
            f.ShowDialog();
        }
    }
}
