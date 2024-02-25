namespace Parte002
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
            this.btnBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBotao
            // 
            this.btnBotao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBotao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBotao.BackgroundImage = global::Parte002.Properties.Resources.Captura_de_tela_2023_05_05_153424;
            this.btnBotao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBotao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBotao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBotao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnBotao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBotao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBotao.Location = new System.Drawing.Point(216, 148);
            this.btnBotao.Name = "btnBotao";
            this.btnBotao.Size = new System.Drawing.Size(351, 112);
            this.btnBotao.TabIndex = 0;
            this.btnBotao.Text = "Botão";
            this.btnBotao.UseVisualStyleBackColor = false;
            this.btnBotao.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBotao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBotao;
    }
}

