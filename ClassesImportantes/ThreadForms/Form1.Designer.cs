namespace ThreadForms
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
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnCOntador = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(158, 29);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(295, 115);
            this.lblResultado.TabIndex = 0;
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Location = new System.Drawing.Point(37, 308);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(282, 89);
            this.btnPrincipal.TabIndex = 1;
            this.btnPrincipal.Text = "Principal";
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click);
            // 
            // btnCOntador
            // 
            this.btnCOntador.Location = new System.Drawing.Point(325, 308);
            this.btnCOntador.Name = "btnCOntador";
            this.btnCOntador.Size = new System.Drawing.Size(282, 89);
            this.btnCOntador.TabIndex = 2;
            this.btnCOntador.Text = "Contador";
            this.btnCOntador.UseVisualStyleBackColor = true;
            this.btnCOntador.Click += new System.EventHandler(this.btnCOntador_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 89);
            this.button1.TabIndex = 3;
            this.button1.Text = "Contador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCOntador);
            this.Controls.Add(this.btnPrincipal);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Button btnCOntador;
        private System.Windows.Forms.Button button1;
    }
}

