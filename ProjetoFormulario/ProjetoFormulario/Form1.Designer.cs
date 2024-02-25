namespace ProjetoFormulario
{
    partial class Form1
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
            this.lblprincipal = new System.Windows.Forms.Label();
            this.btnsegunda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFIle = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mFIleSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreDev = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreVer = new System.Windows.Forms.ToolStripMenuItem();
            this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.menuPesqusisar = new System.Windows.Forms.ToolStripTextBox();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblprincipal
            // 
            this.lblprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprincipal.Location = new System.Drawing.Point(193, 105);
            this.lblprincipal.Name = "lblprincipal";
            this.lblprincipal.Size = new System.Drawing.Size(358, 143);
            this.lblprincipal.TabIndex = 0;
            this.lblprincipal.Text = "PRINCIPAL";
            this.lblprincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsegunda
            // 
            this.btnsegunda.Location = new System.Drawing.Point(12, 326);
            this.btnsegunda.Name = "btnsegunda";
            this.btnsegunda.Size = new System.Drawing.Size(193, 77);
            this.btnsegunda.TabIndex = 1;
            this.btnsegunda.Text = "Segunda Form";
            this.btnsegunda.UseVisualStyleBackColor = true;
            this.btnsegunda.Click += new System.EventHandler(this.btnsegunda_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Segunda Form Thread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menubar
            // 
            this.menubar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.comboMenu,
            this.menuPesqusisar});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(800, 27);
            this.menubar.TabIndex = 3;
            this.menubar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFIle,
            this.mFileAbrir,
            this.toolStripSeparator1,
            this.mFIleSair});
            this.menuFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(38, 23);
            this.menuFile.Text = "File";
            // 
            // mFIle
            // 
            this.mFIle.Image = global::ProjetoFormulario.Properties.Resources.PapelC;
            this.mFIle.Name = "mFIle";
            this.mFIle.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFIle.Size = new System.Drawing.Size(180, 22);
            this.mFIle.Text = "Novo";
            this.mFIle.Click += new System.EventHandler(this.mFIle_Click);
            // 
            // mFileAbrir
            // 
            this.mFileAbrir.Name = "mFileAbrir";
            this.mFileAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mFileAbrir.Size = new System.Drawing.Size(180, 22);
            this.mFileAbrir.Text = "Abrir";
            this.mFileAbrir.Click += new System.EventHandler(this.mFileAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mFIleSair
            // 
            this.mFIleSair.Name = "mFIleSair";
            this.mFIleSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mFIleSair.Size = new System.Drawing.Size(180, 22);
            this.mFIleSair.Text = "Sair";
            this.mFIleSair.Click += new System.EventHandler(this.mFIleSair_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobre});
            this.menuHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(45, 23);
            this.menuHelp.Text = "Help";
            // 
            // mHelpSobre
            // 
            this.mHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobreDev,
            this.mHelpSobreVer});
            this.mHelpSobre.Name = "mHelpSobre";
            this.mHelpSobre.Size = new System.Drawing.Size(180, 22);
            this.mHelpSobre.Text = "Sobre";
            // 
            // mHelpSobreDev
            // 
            this.mHelpSobreDev.Name = "mHelpSobreDev";
            this.mHelpSobreDev.Size = new System.Drawing.Size(180, 22);
            this.mHelpSobreDev.Text = "Desenvolvedor";
            this.mHelpSobreDev.Click += new System.EventHandler(this.mHelpSobreDev_Click);
            // 
            // mHelpSobreVer
            // 
            this.mHelpSobreVer.Name = "mHelpSobreVer";
            this.mHelpSobreVer.Size = new System.Drawing.Size(180, 22);
            this.mHelpSobreVer.Text = "Versão";
            this.mHelpSobreVer.Click += new System.EventHandler(this.mHelpSobreVer_Click);
            // 
            // comboMenu
            // 
            this.comboMenu.Items.AddRange(new object[] {
            "Ingles",
            "Portugues"});
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(121, 23);
            this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // menuPesqusisar
            // 
            this.menuPesqusisar.AutoToolTip = true;
            this.menuPesqusisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuPesqusisar.Name = "menuPesqusisar";
            this.menuPesqusisar.Size = new System.Drawing.Size(200, 23);
            this.menuPesqusisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.menuPesqusisar_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsegunda);
            this.Controls.Add(this.lblprincipal);
            this.Controls.Add(this.menubar);
            this.MainMenuStrip = this.menubar;
            this.Name = "Form1";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprincipal;
        private System.Windows.Forms.Button btnsegunda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mFIle;
        private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFIleSair;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobre;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreDev;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreVer;
        private System.Windows.Forms.ToolStripComboBox comboMenu;
        private System.Windows.Forms.ToolStripTextBox menuPesqusisar;
    }
}

