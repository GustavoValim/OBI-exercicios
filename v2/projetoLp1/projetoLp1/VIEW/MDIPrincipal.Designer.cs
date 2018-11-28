namespace projetoLp1
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procurarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosMaisVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosPorCampanhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.pagamentosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(126, 564);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarToolStripMenuItem,
            this.procurarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // verificarToolStripMenuItem
            // 
            this.verificarToolStripMenuItem.Name = "verificarToolStripMenuItem";
            this.verificarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verificarToolStripMenuItem.Text = "Adicionar";
            this.verificarToolStripMenuItem.Click += new System.EventHandler(this.verificarToolStripMenuItem_Click);
            // 
            // procurarToolStripMenuItem
            // 
            this.procurarToolStripMenuItem.Name = "procurarToolStripMenuItem";
            this.procurarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.procurarToolStripMenuItem.Text = "Procurar";
            this.procurarToolStripMenuItem.Click += new System.EventHandler(this.procurarToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.procurarToolStripMenuItem1});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.adicionarToolStripMenuItem_Click);
            // 
            // procurarToolStripMenuItem1
            // 
            this.procurarToolStripMenuItem1.Name = "procurarToolStripMenuItem1";
            this.procurarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.procurarToolStripMenuItem1.Text = "Procurar";
            this.procurarToolStripMenuItem1.Click += new System.EventHandler(this.procurarToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.verificarVendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.criarToolStripMenuItem.Text = "Criar";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            // 
            // verificarVendaToolStripMenuItem
            // 
            this.verificarVendaToolStripMenuItem.Name = "verificarVendaToolStripMenuItem";
            this.verificarVendaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verificarVendaToolStripMenuItem.Text = "Verificar venda";
            this.verificarVendaToolStripMenuItem.Click += new System.EventHandler(this.verificarVendaToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1,
            this.produtosMaisVendidosToolStripMenuItem,
            this.estatisticaDeClientesToolStripMenuItem,
            this.produtosPorCampanhaToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.relatoriosToolStripMenuItem.Text = "Relatorios";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // produtosMaisVendidosToolStripMenuItem
            // 
            this.produtosMaisVendidosToolStripMenuItem.Name = "produtosMaisVendidosToolStripMenuItem";
            this.produtosMaisVendidosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.produtosMaisVendidosToolStripMenuItem.Text = "Produtos mais vendidos";
            // 
            // estatisticaDeClientesToolStripMenuItem
            // 
            this.estatisticaDeClientesToolStripMenuItem.Name = "estatisticaDeClientesToolStripMenuItem";
            this.estatisticaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.estatisticaDeClientesToolStripMenuItem.Text = "Estatistica de clientes";
            // 
            // produtosPorCampanhaToolStripMenuItem
            // 
            this.produtosPorCampanhaToolStripMenuItem.Name = "produtosPorCampanhaToolStripMenuItem";
            this.produtosPorCampanhaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.produtosPorCampanhaToolStripMenuItem.Text = "Produtos vendidos por mês";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.ajudaToolStripMenuItem.Text = "Encomendar";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            this.pagamentosToolStripMenuItem.Click += new System.EventHandler(this.pagamentosToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(126, 542);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(851, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 564);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPrincipal";
            this.Text = "MDIPrincipal";
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procurarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosMaisVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatisticaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosPorCampanhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
    }
}



