namespace Colecoes
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
            this.lista = new System.Windows.Forms.ListBox();
            this.btnlista = new System.Windows.Forms.Button();
            this.btnHashset = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnsorted = new System.Windows.Forms.Button();
            this.btnSortedDicionary = new System.Windows.Forms.Button();
            this.btnSortedSet = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnstack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 29;
            this.lista.Location = new System.Drawing.Point(14, 13);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(459, 410);
            this.lista.TabIndex = 0;
            // 
            // btnlista
            // 
            this.btnlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlista.Location = new System.Drawing.Point(479, 12);
            this.btnlista.Name = "btnlista";
            this.btnlista.Size = new System.Drawing.Size(202, 53);
            this.btnlista.TabIndex = 1;
            this.btnlista.Text = "Lista";
            this.btnlista.UseVisualStyleBackColor = true;
            this.btnlista.Click += new System.EventHandler(this.btnlista_Click);
            // 
            // btnHashset
            // 
            this.btnHashset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashset.Location = new System.Drawing.Point(479, 71);
            this.btnHashset.Name = "btnHashset";
            this.btnHashset.Size = new System.Drawing.Size(202, 53);
            this.btnHashset.TabIndex = 2;
            this.btnHashset.Text = "Hashset";
            this.btnHashset.UseVisualStyleBackColor = true;
            this.btnHashset.Click += new System.EventHandler(this.btnHashset_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDictionary.Location = new System.Drawing.Point(479, 130);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(202, 53);
            this.btnDictionary.TabIndex = 3;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnsorted
            // 
            this.btnsorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsorted.Location = new System.Drawing.Point(479, 189);
            this.btnsorted.Name = "btnsorted";
            this.btnsorted.Size = new System.Drawing.Size(202, 53);
            this.btnsorted.TabIndex = 4;
            this.btnsorted.Text = "SortedList";
            this.btnsorted.UseVisualStyleBackColor = true;
            this.btnsorted.Click += new System.EventHandler(this.btnsorted_Click);
            // 
            // btnSortedDicionary
            // 
            this.btnSortedDicionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedDicionary.Location = new System.Drawing.Point(479, 248);
            this.btnSortedDicionary.Name = "btnSortedDicionary";
            this.btnSortedDicionary.Size = new System.Drawing.Size(202, 53);
            this.btnSortedDicionary.TabIndex = 5;
            this.btnSortedDicionary.Text = "SortedDictionary";
            this.btnSortedDicionary.UseVisualStyleBackColor = true;
            this.btnSortedDicionary.Click += new System.EventHandler(this.btnSortedDicionary_Click);
            // 
            // btnSortedSet
            // 
            this.btnSortedSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedSet.Location = new System.Drawing.Point(479, 307);
            this.btnSortedSet.Name = "btnSortedSet";
            this.btnSortedSet.Size = new System.Drawing.Size(202, 53);
            this.btnSortedSet.TabIndex = 6;
            this.btnSortedSet.Text = "SortedSet";
            this.btnSortedSet.UseVisualStyleBackColor = true;
            this.btnSortedSet.Click += new System.EventHandler(this.btnSortedSet_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.Location = new System.Drawing.Point(479, 370);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(202, 53);
            this.btnQueue.TabIndex = 7;
            this.btnQueue.Text = "queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnstack
            // 
            this.btnstack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstack.Location = new System.Drawing.Point(479, 429);
            this.btnstack.Name = "btnstack";
            this.btnstack.Size = new System.Drawing.Size(202, 53);
            this.btnstack.TabIndex = 8;
            this.btnstack.Text = "stack";
            this.btnstack.UseVisualStyleBackColor = true;
            this.btnstack.Click += new System.EventHandler(this.btnstack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 486);
            this.Controls.Add(this.btnstack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnSortedSet);
            this.Controls.Add(this.btnSortedDicionary);
            this.Controls.Add(this.btnsorted);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnHashset);
            this.Controls.Add(this.btnlista);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Genericas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnlista;
        private System.Windows.Forms.Button btnHashset;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnsorted;
        private System.Windows.Forms.Button btnSortedDicionary;
        private System.Windows.Forms.Button btnSortedSet;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnstack;
    }
}

