namespace projetoLp1
{
    partial class telaSenha
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_configurar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_configurar);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.txt_login);
            this.panel1.Controls.Add(this.btn_acessar);
            this.panel1.Location = new System.Drawing.Point(203, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 414);
            this.panel1.TabIndex = 0;
            // 
            // btn_configurar
            // 
            this.btn_configurar.Location = new System.Drawing.Point(101, 359);
            this.btn_configurar.Name = "btn_configurar";
            this.btn_configurar.Size = new System.Drawing.Size(166, 39);
            this.btn_configurar.TabIndex = 3;
            this.btn_configurar.Text = "Primeiro Acesso";
            this.btn_configurar.UseVisualStyleBackColor = true;
            this.btn_configurar.Click += new System.EventHandler(this.btn_configurar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(55, 197);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(278, 22);
            this.txt_senha.TabIndex = 2;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(55, 92);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(278, 22);
            this.txt_login.TabIndex = 1;
            // 
            // btn_acessar
            // 
            this.btn_acessar.Location = new System.Drawing.Point(67, 277);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(243, 59);
            this.btn_acessar.TabIndex = 0;
            this.btn_acessar.Text = "Acessar Dados";
            this.btn_acessar.UseVisualStyleBackColor = true;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // telaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 456);
            this.Controls.Add(this.panel1);
            this.Name = "telaSenha";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_configurar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

