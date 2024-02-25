namespace ChatCliente
{
    partial class btnConectar
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
            this.txtServidorIP = new System.Windows.Forms.TextBox();
            this.numPortaHost = new System.Windows.Forms.NumericUpDown();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btconectar = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPortaHost)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServidorIP
            // 
            this.txtServidorIP.Location = new System.Drawing.Point(14, 14);
            this.txtServidorIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServidorIP.Name = "txtServidorIP";
            this.txtServidorIP.Size = new System.Drawing.Size(378, 22);
            this.txtServidorIP.TabIndex = 0;
            this.txtServidorIP.Text = "127.0.0.1";
            // 
            // numPortaHost
            // 
            this.numPortaHost.Location = new System.Drawing.Point(402, 14);
            this.numPortaHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numPortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPortaHost.Name = "numPortaHost";
            this.numPortaHost.Size = new System.Drawing.Size(170, 22);
            this.numPortaHost.TabIndex = 1;
            this.numPortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(14, 46);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(378, 22);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "Visitante";
            // 
            // btconectar
            // 
            this.btconectar.Location = new System.Drawing.Point(402, 46);
            this.btconectar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btconectar.Name = "btconectar";
            this.btconectar.Size = new System.Drawing.Size(168, 25);
            this.btconectar.TabIndex = 3;
            this.btconectar.Text = "Conectar";
            this.btconectar.UseVisualStyleBackColor = true;
            this.btconectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLog.Location = new System.Drawing.Point(11, 81);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(558, 333);
            this.txtLog.TabIndex = 4;
            this.txtLog.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLog_KeyPress);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(14, 420);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(378, 22);
            this.txtMensagem.TabIndex = 5;
            // 
            // btnenviar
            // 
            this.btnenviar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnenviar.Location = new System.Drawing.Point(401, 419);
            this.btnenviar.Margin = new System.Windows.Forms.Padding(4);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(168, 25);
            this.btnenviar.TabIndex = 6;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelStatus.Location = new System.Drawing.Point(14, 448);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(554, 42);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Não conectado";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConectar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 586);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btconectar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.numPortaHost);
            this.Controls.Add(this.txtServidorIP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "btnConectar";
            this.Text = "Conectar";
            this.Load += new System.EventHandler(this.btnConectar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPortaHost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServidorIP;
        private System.Windows.Forms.NumericUpDown numPortaHost;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btconectar;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label labelStatus;
    }
}

