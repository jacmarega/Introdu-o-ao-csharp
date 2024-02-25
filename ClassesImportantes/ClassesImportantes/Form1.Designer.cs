namespace ClassesImportantes
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnaleatorio = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnAplicattion = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Message Box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(167, 68);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(381, 165);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "label1";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnaleatorio
            // 
            this.btnaleatorio.Location = new System.Drawing.Point(240, 372);
            this.btnaleatorio.Name = "btnaleatorio";
            this.btnaleatorio.Size = new System.Drawing.Size(232, 66);
            this.btnaleatorio.TabIndex = 2;
            this.btnaleatorio.Text = "Message Box";
            this.btnaleatorio.UseVisualStyleBackColor = true;
            this.btnaleatorio.Click += new System.EventHandler(this.btnaleatorio_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Location = new System.Drawing.Point(478, 372);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(232, 66);
            this.btnTimeSpan.TabIndex = 3;
            this.btnTimeSpan.Text = "Message Box";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(478, 300);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(232, 66);
            this.btnDateTime.TabIndex = 4;
            this.btnDateTime.Text = "Message Box";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(240, 300);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(232, 66);
            this.btncolor.TabIndex = 5;
            this.btncolor.Text = "Message Box";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnAplicattion
            // 
            this.btnAplicattion.Location = new System.Drawing.Point(2, 300);
            this.btnAplicattion.Name = "btnAplicattion";
            this.btnAplicattion.Size = new System.Drawing.Size(232, 66);
            this.btnAplicattion.TabIndex = 6;
            this.btnAplicattion.Text = "Message Box";
            this.btnAplicattion.UseVisualStyleBackColor = true;
            this.btnAplicattion.Click += new System.EventHandler(this.btnAplicattion_Click);
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(2, 228);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(232, 66);
            this.btnfont.TabIndex = 7;
            this.btnfont.Text = "Fonte";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 66);
            this.button2.TabIndex = 8;
            this.button2.Text = "Envivioment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 66);
            this.button3.TabIndex = 9;
            this.button3.Text = "Thread";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btnAplicattion);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btnaleatorio);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnaleatorio;
        private System.Windows.Forms.Button btnTimeSpan;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Button btnAplicattion;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

