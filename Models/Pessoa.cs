using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gft_bootcamp.Models
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}