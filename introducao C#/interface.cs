using System;

namespace Interface{
    interface IDados{
        void Nome(string nome);
        void Idade(int idade);
        void Estado(string estado);
    }

    class Dados: IDados{
        public string Nome{get; set;}
        public int Idade{get; set;}
        public string Estado{get; set;}

        void IDados.Nome(string nome){
            this.Nome = nome;
        }
        void IDados.Idade(int idade){
            this.Idade = idade;
        }
        void IDados.Estado(string estado){
            this.Estado = estado;
        }
    }
}