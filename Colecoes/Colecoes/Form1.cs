using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //array
            string[] nomes = new string[3];
            nomes[0] = "Joao";
            nomes[1] = "Joao";
            nomes[2] = "Joao";
            //Lista generica
            List<string> nomes2 = new List<string>();
            nomes2.Add("Augusto");
            nomes2.Add("Comossato");
            nomes2.AddRange(nomes);
            nomes2.Remove("Comossato");
            //if (nomes2.Remove("Comossato"))
            //{
            //    MessageBox.Show("Item removido");
            //}
            //else
            //{
            //    MessageBox.Show("não foi possivel remover");
            //}

            //if (nomes2.Contains("Augusto"))
            //{
            //    MessageBox.Show("Contem");
            //}
            //else
            //{
            //    MessageBox.Show("Não contem");
            //}

            //MessageBox.Show("nUmeros de elementos: " + nomes2.Count);
            //nomes2.Sort();
            //MessageBox.Show("Joao está no indice: " + nomes2.IndexOf("Augusto"));
            nomes2.Insert(2, "BIA");
            nomes2.RemoveAt(1);
            nomes2.Clear();
            //lista.Items.Add(nomes2[1]); Assim imprime

            foreach (string nome in nomes2) {
                lista.Items.Add(nome);
            }

        }

        private void btnHashset_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            HashSet<string> veiculos = new HashSet<string>()
            {
                "Gol",
                "onix",
                "carro",
                "aviao"
            };

            if (veiculos.Add("Gol"))
            {
                MessageBox.Show("Item adicionado");
            }
            else
            {
                MessageBox.Show("Não adicionado");
            }
            foreach (string item in veiculos)
            {
                lista.Items.Add(item);
            }
            if (veiculos.Contains("Carro"))
            {
                MessageBox.Show("Contem");
            }
            else
            {
                MessageBox.Show("Não contem");
            }
            veiculos.Remove("Carro");
            int tamanho = veiculos.Count();
            veiculos.Clear();
            MessageBox.Show(veiculos.ElementAt(2));
            MessageBox.Show(veiculos.First());   
            MessageBox.Show(veiculos.Last());   
            veiculos.Add("João");
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                {150, "Joao" },
                {50, "augusto" },
                {80, "bia" }
            };
            alunos.Add(100, "Joao");

            foreach (KeyValuePair<int, string> item in alunos) {
                lista.Items.Add(item.Value);
            }
           // MessageBox.Show("Quantidade: " + alunos.Count());
            alunos.Remove(80);
            alunos.Clear();
            MessageBox.Show("" + alunos.First());
            MessageBox.Show("" + alunos.Last());
            //(alunos.ContainsKey(200))

            if (alunos.ContainsValue("Joao"))
            {
                MessageBox.Show("Contem");

            }
            else
            {
                MessageBox.Show("Não contem");

            }//se contem uma chave ou nao
            KeyValuePair<int, string> primeiro = alunos.First();

        }

        private void btnsorted_Click(object sender, EventArgs e)
        {
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                { 27, "Joao" },
                { 10, "Augusto" },
                { 5, "Comossato" }
            };
            alunos.Add(15, "gloria");

            alunos.Remove(5);
            alunos.RemoveAt(0);//remove por indice
            //alunos.Count();
            //alunos.ContainsKey(5);
            alunos.ContainsValue("Joao");
            foreach(KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item.Key + " " + item.Value);
            } 
            foreach(KeyValuePair<int, string> item in alunos.Reverse())
            {
                lista.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void btnSortedDicionary_Click(object sender, EventArgs e)
        {
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {4512, "Joao" },
                {1542, "augusto" },
                {2145, "comossato" }

            };
            alunos.Add(5478, "MAREGA");
            foreach(KeyValuePair<int, string> item in alunos)
            {
                lista.Items.Add(item);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Joao", "peter", "malia", "beatriz"
            };
            if (!nomes.Add("Joao"))
            {
                MessageBox.Show("Não pode repetir o valor");
            }
            
            foreach(string nome in nomes)
            {
                lista.Items.Add(nome);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Joao");
            fila.Enqueue("joaoo");
            fila.Enqueue("augusto");
            fila.Enqueue("augusto");

            MessageBox.Show(fila.Count.ToString());
            foreach(string item in fila)
            {
                lista.Items.Add(item);
            }
            //MessageBox.Show("Primeiro da fila: " + fila.Peek());
            //MessageBox.Show("Primeiro da fila: " + fila.Dequeue());

            //MessageBox.Show("Primeiro da fila: " + fila.First());
            //MessageBox.Show("Primeiro da fila: " + fila.Last());
            //fila.Clear();


            MessageBox.Show(fila.Count.ToString());
            while(fila.Count > 0)
            {
                MessageBox.Show(fila.Count.ToString());
                MessageBox.Show("Primeiro da fila: " + fila.Dequeue());
                lista.Items.Clear();
                foreach (string item in fila)
                {
                    lista.Items.Add(item);

                }
            }
        }

        private void btnstack_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Stack<string> pilha = new Stack<string>();
            pilha.Push("joao");
            pilha.Push("augusto");
            pilha.Push("augusto");
            pilha.Push("comossato");

            
            //foreach (string item in pilha)
            //{
            //    lista.Items.Add(item);
            //}

            while(pilha.Count > 0)
            {
                MessageBox.Show(pilha.Pop());
                MessageBox.Show(pilha.Count.ToString());
                pilha.Clear();
                foreach (string item in pilha)
                {
                    lista.Items.Add(item);
                }
            }
            //MessageBox.Show(pilha.Peek());//retorna sem remover
            //MessageBox.Show(pilha.Pop());//retorna o topo e remove
            //MessageBox.Show(pilha.Count.ToString());

            
        }
    }
}

