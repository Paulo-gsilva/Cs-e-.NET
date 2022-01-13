using ExemploConstrutores.Models;
namespace ExemploConstrutores{
    class Program{

        static void Main(string[] args){

/*
            Pessoa p = new Pessoa("Paulo", "Guilherme");
            p.Apresentar();

            Aluno a = new Aluno("Pedro", "Araujo", "Mat");
            */

            Data dat = new Data();
            dat.SetMes(5);
            dat.ApresentarMes();
        }
    }
}