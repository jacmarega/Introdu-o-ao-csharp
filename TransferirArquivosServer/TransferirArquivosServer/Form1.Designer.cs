namespace TransferirArquivosServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoIp = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.btnconexao = new System.Windows.Forms.Button();
            this.btnparar = new System.Windows.Forms.Button();
            this.txtPasta = new System.Windows.Forms.LinkLabel();
            this.listalogs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor compartilhar arquivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnderecoIp
            // 
            this.txtEnderecoIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoIp.Location = new System.Drawing.Point(12, 77);
            this.txtEnderecoIp.Name = "txtEnderecoIp";
            this.txtEnderecoIp.Size = new System.Drawing.Size(215, 24);
            this.txtEnderecoIp.TabIndex = 1;
            this.txtEnderecoIp.Text = "127.0.0.1";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(233, 77);
            this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(104, 20);
            this.txtPorta.TabIndex = 2;
            this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnconexao
            // 
            this.btnconexao.Location = new System.Drawing.Point(14, 120);
            this.btnconexao.Name = "btnconexao";
            this.btnconexao.Size = new System.Drawing.Size(269, 41);
            this.btnconexao.TabIndex = 3;
            this.btnconexao.Text = "Estabelecer Conexão";
            this.btnconexao.UseVisualStyleBackColor = true;
            this.btnconexao.Click += new System.EventHandler(this.btnconexao_Click);
            // 
            // btnparar
            // 
            this.btnparar.Location = new System.Drawing.Point(289, 120);
            this.btnparar.Name = "btnparar";
            this.btnparar.Size = new System.Drawing.Size(265, 41);
            this.btnparar.TabIndex = 4;
            this.btnparar.Text = "Parar Servidor";
            this.btnparar.UseVisualStyleBackColor = true;
            this.btnparar.Click += new System.EventHandler(this.btnparar_Click);
            // 
            // txtPasta
            // 
            this.txtPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasta.Location = new System.Drawing.Point(17, 173);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(536, 31);
            this.txtPasta.TabIndex = 5;
            this.txtPasta.TabStop = true;
            this.txtPasta.Text = "Clique para selecionar a pasta";
            this.txtPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtPasta_LinkClicked);
            // 
            // listalogs
            // 
            this.listalogs.FormattingEnabled = true;
            this.listalogs.Location = new System.Drawing.Point(13, 216);
            this.listalogs.Name = "listalogs";
            this.listalogs.Size = new System.Drawing.Size(539, 108);
            this.listalogs.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 345);
            this.Controls.Add(this.listalogs);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.btnparar);
            this.Controls.Add(this.btnconexao);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtEnderecoIp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoIp;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.Button btnconexao;
        private System.Windows.Forms.Button btnparar;
        private System.Windows.Forms.LinkLabel txtPasta;
        private System.Windows.Forms.ListBox listalogs;
    }
}

