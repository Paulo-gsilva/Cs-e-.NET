using System;

namespace Estrutura{
    class Programa{
        static void Main(){

            var p = new Pilha();
            p.Empilha(1);
            p.Empilha(2);
            p.Empilha(3);
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
            Console.WriteLine(p.Desempilha());
        }
    }
}