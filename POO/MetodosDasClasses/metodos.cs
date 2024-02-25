using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class metodos
    {
        //metodos simples
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo");

        }

        //metodos com parametros
        public void Somar(int num1, int num2)

        {
            int resultado = num1 + num2;
            Console.WriteLine($"A soma é: {resultado} ");

        }

        public void apresentar(string nome, int idade)
        {
            Console.WriteLine($"Meu nome é {nome} e minha idade é {idade}");

        }

        //Passagem de parametros por valor
        public void aumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine($"O valor final (valor): {valor}");

        }

        //passagem de parametros por referencia
        public void aumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"O valor final (referencia): {valor}");

        }

        //metodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            string nomeCompleto = nome + " " + sobrenome;

            return nomeCompleto;
        }

        public int CodigoChar(char caractere)
        {
            int codigo = caractere;

            return codigo;
        }

        public double ValorPI()
        {
            return 3.1415;
        }
        //Sobrecarga de metodos
        public void Cumprimentar(string nome)
        {
            Console.WriteLine($"Olá, {nome}");

        }

        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia" + nome : "Boa tarde " + nome;
            Console.WriteLine($"Bom dia, {nome}");

        }
        public bool Comparar(int numUm, int numDois)
        {
            return numUm == numDois;
        }

        public bool Comparar(string txt, string txtDois)
        {
            return txt == txtDois;
        }


    }
}
