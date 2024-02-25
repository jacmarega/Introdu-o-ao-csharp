using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamdba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            //a expressao lambda tem uma expressao como corpo:
            //(input - parameters) => expression

            //intrução lambda que tem um bloco de instruãõ como corpo:
            //(input - parameter) => { < sequence - of 0 statements >}

            //METODO NORMAL
            //Func<int, int> squaree = quadrado;
            //METODO LAMBDA
            Func<int, int> square = x => x * x;

            lblResultado.Text = "O resultado é " + square(5);

            Expression<Func<int, int>> ex = x => x * x;

            lblResultado.Text = ex.ToString();

            int[] number = { 2, 3, 4, 5, 6 };
            var squaredNumbers = number.Select(x => x * x);
            lblResultado.Text = string.Join(" ", squaredNumbers);

            Action<string> greet = name =>
            {
                string greeting = $"hello {name}";
                lblResultado.Text = greeting;
            };

            Action line = () => Console.WriteLine();

            lblResultado.Text = "Gabriel" + line+ "marega";

            Func<int, int, bool> texteforEquality = (x, y) => x == y;
            lblResultado.Text = texteforEquality(10, 10).ToString();

            int quadrado(int x)
            {
                return x * x;
            }
            
        }
    }
}
