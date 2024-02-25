namespace Parte041
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
            this.lblCor = new System.Windows.Forms.Label();
            this.btnCor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblCor
            // 
            this.lblCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCor.Location = new System.Drawing.Point(246, 76);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(276, 80);
            this.lblCor.TabIndex = 0;
            this.lblCor.Text = "Selecione a cor";
            this.lblCor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCor
            // 
            this.btnCor.Location = new System.Drawing.Point(108, 332);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(163, 61);
            this.btnCor.TabIndex = 1;
            this.btnCor.Text = "Cor";
            this.btnCor.UseVisualStyleBackColor = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCor);
            this.Controls.Add(this.lblCor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

