namespace Graficos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xValor = new System.Windows.Forms.TextBox();
            this.yValor = new System.Windows.Forms.TextBox();
            this.btnInserirValores = new System.Windows.Forms.Button();
            this.dataValores = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tipoGrafico = new System.Windows.Forms.ComboBox();
            this.palleteColor = new System.Windows.Forms.ComboBox();
            this.grafico3D = new System.Windows.Forms.CheckBox();
            this.btnAleatório = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grafico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor de Y";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xValor
            // 
            this.xValor.Location = new System.Drawing.Point(6, 69);
            this.xValor.Name = "xValor";
            this.xValor.Size = new System.Drawing.Size(104, 20);
            this.xValor.TabIndex = 3;
            this.xValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xValor_KeyPress);
            // 
            // yValor
            // 
            this.yValor.Location = new System.Drawing.Point(109, 69);
            this.yValor.Name = "yValor";
            this.yValor.Size = new System.Drawing.Size(104, 20);
            this.yValor.TabIndex = 4;
            this.yValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yValor_KeyPress);
            // 
            // btnInserirValores
            // 
            this.btnInserirValores.BackColor = System.Drawing.SystemColors.Control;
            this.btnInserirValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirValores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserirValores.Location = new System.Drawing.Point(6, 95);
            this.btnInserirValores.Name = "btnInserirValores";
            this.btnInserirValores.Size = new System.Drawing.Size(207, 40);
            this.btnInserirValores.TabIndex = 5;
            this.btnInserirValores.Text = "Inserir valores no gráfico";
            this.btnInserirValores.UseVisualStyleBackColor = false;
            this.btnInserirValores.Click += new System.EventHandler(this.btnInserirValores_Click);
            // 
            // dataValores
            // 
            this.dataValores.AllowUserToAddRows = false;
            this.dataValores.AllowUserToDeleteRows = false;
            this.dataValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataValores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataValores.Location = new System.Drawing.Point(6, 141);
            this.dataValores.MultiSelect = false;
            this.dataValores.Name = "dataValores";
            this.dataValores.ReadOnly = true;
            this.dataValores.RowHeadersVisible = false;
            this.dataValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataValores.Size = new System.Drawing.Size(207, 161);
            this.dataValores.TabIndex = 6;
            this.dataValores.SelectionChanged += new System.EventHandler(this.dataValores_SelectionChanged);
            // 
            // x
            // 
            this.x.HeaderText = "Eixo X";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            // 
            // y
            // 
            this.y.HeaderText = "Eixo y";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(6, 308);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(207, 40);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Gráfico";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // tipoGrafico
            // 
            this.tipoGrafico.FormattingEnabled = true;
            this.tipoGrafico.Location = new System.Drawing.Point(9, 355);
            this.tipoGrafico.Name = "tipoGrafico";
            this.tipoGrafico.Size = new System.Drawing.Size(203, 21);
            this.tipoGrafico.TabIndex = 8;
            this.tipoGrafico.Text = "Selecione um tipo de grafico...";
            this.tipoGrafico.SelectedIndexChanged += new System.EventHandler(this.tipoGrafico_SelectedIndexChanged);
            // 
            // palleteColor
            // 
            this.palleteColor.FormattingEnabled = true;
            this.palleteColor.Location = new System.Drawing.Point(218, 356);
            this.palleteColor.Name = "palleteColor";
            this.palleteColor.Size = new System.Drawing.Size(203, 21);
            this.palleteColor.TabIndex = 9;
            this.palleteColor.Text = "Selecione uma paleta de cor..";
            this.palleteColor.SelectedIndexChanged += new System.EventHandler(this.palleteColor_SelectedIndexChanged);
            // 
            // grafico3D
            // 
            this.grafico3D.Location = new System.Drawing.Point(427, 355);
            this.grafico3D.Name = "grafico3D";
            this.grafico3D.Size = new System.Drawing.Size(88, 22);
            this.grafico3D.TabIndex = 10;
            this.grafico3D.Text = "Gráfico 3D";
            this.grafico3D.UseVisualStyleBackColor = true;
            this.grafico3D.CheckedChanged += new System.EventHandler(this.grafico3D_CheckedChanged);
            // 
            // btnAleatório
            // 
            this.btnAleatório.Location = new System.Drawing.Point(506, 347);
            this.btnAleatório.Name = "btnAleatório";
            this.btnAleatório.Size = new System.Drawing.Size(126, 35);
            this.btnAleatório.TabIndex = 11;
            this.btnAleatório.Text = "Valores Aleatórios";
            this.btnAleatório.UseVisualStyleBackColor = true;
            this.btnAleatório.Click += new System.EventHandler(this.btnAleatório_Click);
            // 
            // grafico
            // 
            chartArea20.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.grafico.Legends.Add(legend20);
            this.grafico.Location = new System.Drawing.Point(223, 6);
            this.grafico.Name = "grafico";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.Name = "X vs Y";
            this.grafico.Series.Add(series20);
            this.grafico.Size = new System.Drawing.Size(416, 317);
            this.grafico.TabIndex = 12;
            this.grafico.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 389);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btnAleatório);
            this.Controls.Add(this.grafico3D);
            this.Controls.Add(this.palleteColor);
            this.Controls.Add(this.tipoGrafico);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.dataValores);
            this.Controls.Add(this.btnInserirValores);
            this.Controls.Add(this.yValor);
            this.Controls.Add(this.xValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Grafico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xValor;
        private System.Windows.Forms.TextBox yValor;
        private System.Windows.Forms.Button btnInserirValores;
        private System.Windows.Forms.DataGridView dataValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox tipoGrafico;
        private System.Windows.Forms.ComboBox palleteColor;
        private System.Windows.Forms.CheckBox grafico3D;
        private System.Windows.Forms.Button btnAleatório;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Timer timer1;
    }
}

