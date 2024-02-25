using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imprimir
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int largura;
        int altura;
        int num_linhas;
        int pagina;
        int num_paginas;
        public Form1()
        {
            InitializeComponent();
            pagina = 0;
            num_paginas = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                largura = printDocument1.DefaultPageSettings.Bounds.Width;
                altura = printDocument1.DefaultPageSettings.Bounds.Height;
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region parte 1

            //string texto = "Trabalhando com impressão.";
            //Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            //Point pontoInicial = new Point(100, 50);
            ////Desenhar o documento para ser impresso
            //e.Graphics.DrawString(texto, letra, pincel, pontoInicial);

            #endregion

            #region parte 2
            //Rectangle area = printDocument1.DefaultPageSettings.Bounds;
            //int x = printDocument1.DefaultPageSettings.Bounds.X;
            //int y = printDocument1.DefaultPageSettings.Bounds.Y;
            //int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            //int altura = printDocument1.DefaultPageSettings.Bounds.Height;

            //string titulo = "Titulo da Pagina";
            //Font letratitulo = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pinceltitulo = new SolidBrush(Color.Black);
            //Rectangle areatitulo = new Rectangle(x + 50, y + 100, largura- 100, 1003);
            //StringFormat formatotitlo = new StringFormat();
            //formatotitlo.Alignment = StringAlignment.Center;
            //formatotitlo.LineAlignment = StringAlignment.Center;
            ////Desenhar o documento para ser impresso

            //string texto = "Trabalhando com impressão.";
            //Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            //Rectangle areatexto = new Rectangle(x + 50, y + 100, largura - 100, altura - 200);

            //e.Graphics.DrawString(titulo, letratitulo, pinceltitulo, areatitulo, formatotitlo);
            //e.Graphics.DrawString(texto, letra, pincel, areatexto);
            //e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areatitulo);
            //e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areatexto);



            #endregion

            #region parte 3

            List<string> linhas = new List<string>()
            {

            };

            string titulo = "Titulo da Pagina";
            Font letratitulo = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            Brush pinceltitulo = new SolidBrush(Color.Black);
            Rectangle areatitulo = new Rectangle(x, y, largura - 100, 100);
            StringFormat formatotitlo = new StringFormat();
            formatotitlo.Alignment = StringAlignment.Center;
            formatotitlo.LineAlignment = StringAlignment.Center;
            //Desenhar o documento para ser impresso

            Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);

            while (num_linhas < linhas.Count)
            {
                if(num_linhas  == 0)
                {
                    e.Graphics.DrawString(titulo, letratitulo, pinceltitulo, areatitulo, formatotitlo);
                    y += 150;
                }
                e.Graphics.DrawString(linhas[num_linhas], letra, pincel, new Point(x, y));
                y += 30;
                num_linhas++;
                if (y >= altura - 50)
                {
                    y = 50;
                    e.HasMorePages = true;
                    num_paginas++;
                    break;
                }
            }

            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printPreviewControl1.Document = printDocument1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pagina > 0)
            {
                printPreviewControl1.StartPage = --pagina;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pagina > num_paginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }
        }

        private void btnVisualizarpadrao_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
