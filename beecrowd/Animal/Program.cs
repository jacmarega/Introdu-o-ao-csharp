using System;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string classficacaoVertebral = Console.ReadLine();
            string filo = Console.ReadLine();
            string come = Console.ReadLine();

            if (classficacaoVertebral == "vertebrado")
            {
                if (filo == "ave")
                {
                    if (come == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (come == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (filo == "mamifero")
                {
                    if (come == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (come == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (classficacaoVertebral == "invertebrado")
            {
                if (filo == "inseto")
                {
                    if (come == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (come == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (filo == "anelideo")
                {
                    if (come == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (come == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
