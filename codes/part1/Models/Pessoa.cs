using System;

namespace Part1.Models {
    public class Pessoa {
        public string Nome { get; set;} = string.Empty;
        public int Idade { get; set;}

        public void Apresentar() {
            Console.WriteLine($"Meu nome e {Nome} e tenho {Idade} anos");
        }
        
    }
}