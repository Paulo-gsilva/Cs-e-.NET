namespace ExemploConstrutores.Models{
    class Aluno : Pessoa{

        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome){
            System.Console.WriteLine("Constutor Classe Aluno");
        }
    }
}