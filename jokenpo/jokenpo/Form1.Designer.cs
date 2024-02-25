namespace jokenpo
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.picresultado = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnpapel = new System.Windows.Forms.Button();
            this.btntesoura = new System.Windows.Forms.Button();
            this.labelJogador = new System.Windows.Forms.Label();
            this.labelpc = new System.Windows.Forms.Label();
            this.labelempate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picresultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(144, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(550, 98);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Escolha pedra papel ou tesoura";
            // 
            // picresultado
            // 
            this.picresultado.Location = new System.Drawing.Point(25, 81);
            this.picresultado.Name = "picresultado";
            this.picresultado.Size = new System.Drawing.Size(200, 200);
            this.picresultado.TabIndex = 1;
            this.picresultado.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(294, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(560, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(87, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Voce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(365, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "PC";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.SystemColors.Control;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelResultado.Location = new System.Drawing.Point(646, 166);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(25, 25);
            this.labelResultado.TabIndex = 6;
            this.labelResultado.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(231, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "VS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(512, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::jokenpo.Properties.Resources.PedraJ;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPedra.Location = new System.Drawing.Point(25, 287);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(200, 200);
            this.btnPedra.TabIndex = 9;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnpapel
            // 
            this.btnpapel.BackgroundImage = global::jokenpo.Properties.Resources.PapelJ;
            this.btnpapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnpapel.Location = new System.Drawing.Point(294, 287);
            this.btnpapel.Name = "btnpapel";
            this.btnpapel.Size = new System.Drawing.Size(200, 200);
            this.btnpapel.TabIndex = 10;
            this.btnpapel.UseVisualStyleBackColor = true;
            this.btnpapel.Click += new System.EventHandler(this.btnpapel_Click);
            // 
            // btntesoura
            // 
            this.btntesoura.BackgroundImage = global::jokenpo.Properties.Resources.TesouraJ;
            this.btntesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btntesoura.Location = new System.Drawing.Point(560, 287);
            this.btntesoura.Name = "btntesoura";
            this.btntesoura.Size = new System.Drawing.Size(200, 200);
            this.btntesoura.TabIndex = 11;
            this.btntesoura.UseVisualStyleBackColor = true;
            this.btntesoura.Click += new System.EventHandler(this.btntesoura_Click);
            // 
            // labelJogador
            // 
            this.labelJogador.Location = new System.Drawing.Point(12, 9);
            this.labelJogador.Name = "labelJogador";
            this.labelJogador.Size = new System.Drawing.Size(125, 19);
            this.labelJogador.TabIndex = 12;
            this.labelJogador.Text = "label4";
            // 
            // labelpc
            // 
            this.labelpc.Location = new System.Drawing.Point(12, 30);
            this.labelpc.Name = "labelpc";
            this.labelpc.Size = new System.Drawing.Size(125, 19);
            this.labelpc.TabIndex = 13;
            this.labelpc.Text = "label4";
            // 
            // labelempate
            // 
            this.labelempate.Location = new System.Drawing.Point(12, 49);
            this.labelempate.Name = "labelempate";
            this.labelempate.Size = new System.Drawing.Size(125, 19);
            this.labelempate.TabIndex = 14;
            this.labelempate.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.labelempate);
            this.Controls.Add(this.labelpc);
            this.Controls.Add(this.labelJogador);
            this.Controls.Add(this.btntesoura);
            this.Controls.Add(this.btnpapel);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picresultado);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picresultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox picresultado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnpapel;
        private System.Windows.Forms.Button btntesoura;
        private System.Windows.Forms.Label labelJogador;
        private System.Windows.Forms.Label labelpc;
        private System.Windows.Forms.Label labelempate;
    }
}

