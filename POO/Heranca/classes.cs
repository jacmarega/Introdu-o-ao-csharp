using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class  Humano
    {
        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }
    class Pessoa : Humano
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }
        public sealed override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }
    class Homem : Pessoa
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //} Não pode ter o poder de alterar por causa do SEALED
        //public override void Cabelos()
        //{
        //Console.WriteLine("Homem.Cabelos");
        }
    }

