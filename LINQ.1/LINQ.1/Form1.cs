using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ._1
{
    public partial class Form1 : Form
    {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_estados;

        public Form1()
        {
            InitializeComponent();
            #region nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Joao");
            lista_nomes.Add("lucas");
            lista_nomes.Add("william");
            lista_nomes.Add("hugo");
            #endregion

            #region numeros
            lista_numeros = new List<int>();
            lista_numeros.Add(10);
            lista_numeros.Add(20);
            lista_numeros.Add(30);
            lista_numeros.Add(40);
            lista_numeros.Add(50);

            #endregion

            #region produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Teclado Usb", 49.50);
            lista_produtos.Add("mouse", 19.50);
            lista_produtos.Add("Teclado ", 700.00);
            lista_produtos.Add("Teclado Us", 190);

            #endregion

            #region estados
            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("Rio de janeiro", "Brasil");
            lista_estados.Add("Mato Grosso", "Brasil");
            lista_estados.Add("Bahia", "Brasil");
            lista_estados.Add("Sao paulo", "Brasil");

            #endregion


        }
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //Obter a fonte dos dados
            //criar a consulta
            //executar a consulta

            //IEnumerable<int> res = from num in lista_numeros where num % 2 == 0 select num;
       
            //foreach(int n in res)
            //{
            //    lista.Items.Add(n);
            //}
            string txt = pesquisa.Text;
            IEnumerable<string> res2 = from nome in lista_nomes
                                       where nome.StartsWith(txt)
                                       select nome;
            //lista.Items.AddRange(res2.ToArray());

            foreach(string n in res2)
            {
                lista.Items.Add(n);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Operador de filtragem, clasula where

            string txt = pesquisa.Text.ToLower();
            var res = from nome in lista_nomes
                      where nome.ToLower().Contains(txt)
                      select nome;
            foreach(string n in res)
            {
                lista.Items.Add(n);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Operador de ordenação
            lista.Items.Clear();
            string txt = pesquisa.Text;

            var res2 = from produto in lista_produtos 
                      orderby produto.Key
                      select produto;
            foreach (var n in res2)
            {
                lista.Items.Add(n);
            }
        

        var res = from num in lista_numeros
                      orderby num descending //ascedendig
                      where num <= 10
                      select num;
            foreach (var n in res)
            {
                lista.Items.Add(n);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Operadores de agrupamento
            lista.Items.Clear();
            pesquisa.Text = "";
            string txt = pesquisa.Text;

            var res = from estado in lista_estados
                      group estado by estado.Value;
            foreach (var item in res)
            {
                lista.Items.Add(item.Key);
                
               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cont1 = lista_nomes.Count();
            int cont2 = (from nomes in lista_nomes where nomes.StartsWith("j") select nomes).Count();

            lista.Items.Add(cont1 + " nomes.");
            lista.Items.Add(cont2 + " nomes com a letra j");

            double media1 = lista_numeros.Average();
            lista.Items.Add(media1 + " media");

            var res1 = from num in lista_numeros where num < 10 select num;
            double media2 = res1.Average();
            lista.Items.Add(media2 + " nedia menores que 10");

            int soma = lista_numeros.Sum();
            lista.Items.Add(soma + " soma dos valores.");

            lista.Items.Add(lista_numeros.Min());
            lista.Items.Add(lista_numeros.Max());

            long contagem = lista_numeros.LongCount();

            string maiorNome = lista_nomes.Aggregate(lista_nomes[0], (maior, proximo) => { 
                if(maior.ToString().Length > proximo.Length)
                {
                    return maior;
                }
                else
                {
                    return proximo;
                }
            });
            lista.Items.Add(maiorNome + " maior nome da lista");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            int primeiro = lista_numeros.FirstOrDefault();
            lista.Items.Add(primeiro);

            int ultimo = lista_numeros.LastOrDefault();
            lista.Items.Add(primeiro);

            int elemento = lista_numeros.ElementAt(3);
            lista.Items.Add(elemento);

            var consulta = from num in lista_numeros where num > 1000 select num;
            int numero = consulta.FirstOrDefault();
            lista.Items.Add(numero);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // var cons1 = from nome in lista_nomes select nome;//comum
            // var cons1 = lista_nomes.Select(nome => nome);
           
            var cons1 = from nome in lista_nomes where nome.StartsWith("G")select nome;
            var cons2l = lista_nomes.Where((nome) => nome.StartsWith("G"));
            lista.Items.AddRange(cons1.ToArray());

            var cons3 = from nome in lista_nomes orderby nome select nome;
            var cons4 = lista_nomes.OrderBy(nome => nome);
            lista.Items.AddRange(cons3.ToArray());

            var con5 = from estado in lista_estados group estado by estado.Value;
            var cons5l = lista_estados.GroupBy(estado => estado.Value);


            foreach(var grupo in cons4)
            {
                lista.Items.Add(grupo.Key);
                foreach(var estado in grupo)
                {
                    lista.Items.Add(estado.Key);
                }
            }

        }
    }
}