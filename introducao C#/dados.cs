using System;
using Info;
using Interface;
using Enum;

namespace testando{
    class testes{
        static void Main(string[] args){
            
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Paulo";
            pessoa.Idade = 20;
            pessoa.Estado = "Ceará";

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Idade);
            Console.WriteLine(pessoa.Estado);

            /*
            Dados dados = new Dados();
            dados.Nome = "Paulo";
            dados.Idade = 20;
            dados.Estado = "Ceará"; */
            
            var alguem1 = (Alguem)1;
            Alguem alguem2 = Alguem.Gustavo;
        }
    }
}