using System;

    namespace herança{
        public class Pessoa{

            public string Nome { get; set; }
            public int Idade { get; set; }

            public virtual void Apresentar(){ //virtual: possibilita sobrescrição
                System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
                System.Console.WriteLine("");
            }

        }

    }

