namespace CriptoStringMD5
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
            this.txtEntradaa = new System.Windows.Forms.TextBox();
            this.txtsaida = new System.Windows.Forms.TextBox();
            this.btncripto = new System.Windows.Forms.Button();
            this.btncomparar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntradaa
            // 
            this.txtEntradaa.Location = new System.Drawing.Point(16, 15);
            this.txtEntradaa.Multiline = true;
            this.txtEntradaa.Name = "txtEntradaa";
            this.txtEntradaa.Size = new System.Drawing.Size(436, 94);
            this.txtEntradaa.TabIndex = 0;
            // 
            // txtsaida
            // 
            this.txtsaida.Location = new System.Drawing.Point(16, 115);
            this.txtsaida.Multiline = true;
            this.txtsaida.Name = "txtsaida";
            this.txtsaida.Size = new System.Drawing.Size(436, 94);
            this.txtsaida.TabIndex = 1;
            // 
            // btncripto
            // 
            this.btncripto.Location = new System.Drawing.Point(16, 215);
            this.btncripto.Name = "btncripto";
            this.btncripto.Size = new System.Drawing.Size(214, 67);
            this.btncripto.TabIndex = 2;
            this.btncripto.Text = "Criptografar";
            this.btncripto.UseVisualStyleBackColor = true;
            this.btncripto.Click += new System.EventHandler(this.btncripto_Click);
            // 
            // btncomparar
            // 
            this.btncomparar.Location = new System.Drawing.Point(236, 215);
            this.btncomparar.Name = "btncomparar";
            this.btncomparar.Size = new System.Drawing.Size(216, 67);
            this.btncomparar.TabIndex = 3;
            this.btncomparar.Text = "Comparar";
            this.btncomparar.UseVisualStyleBackColor = true;
            this.btncomparar.Click += new System.EventHandler(this.btncomparar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(74, 321);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(323, 90);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado";
            this.lblresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btncomparar);
            this.Controls.Add(this.btncripto);
            this.Controls.Add(this.txtsaida);
            this.Controls.Add(this.txtEntradaa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaa;
        private System.Windows.Forms.TextBox txtsaida;
        private System.Windows.Forms.Button btncripto;
        private System.Windows.Forms.Button btncomparar;
        private System.Windows.Forms.Label lblresultado;
    }
}

