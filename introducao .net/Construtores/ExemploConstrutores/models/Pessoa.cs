namespace ExemploConstrutores.Models{

    public class Pessoa{

        private String nome;
        private String sobrenome;
/*
        public Pessoa(){ //Construtor
            nome = string.Empty;
            sobrenome = string.Empty;
        }*/

        public Pessoa(string nome, string sobrenome){ //Construtor
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Classe Pessoa");
        }

        public void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }

    }
    
}