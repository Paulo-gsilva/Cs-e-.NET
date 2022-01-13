using System;

namespace Cadastro{
    class Program{
        
        static void Main(String[] args){

            Aluno[] alunos = new Aluno[3];
            int indiceAluno = 0;
            string opcaoUsuario = VerificaOpcao();

            while (opcaoUsuario.ToUpper() != "X"){
                switch (opcaoUsuario){
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno =  new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }
                        else    
                            throw new ArgumentException("Valor deve ser decimal");             
                        

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        break;

                    case "2":

                        foreach(var al in alunos){

                            if(!string.IsNullOrEmpty(al.Nome)){
                                Console.WriteLine($"ALUNO: {al.Nome} - NOTA: {al.Nota}");
                            }
                        }
                        break;

                    case "3":

                        decimal notaTotal = 0;
                        var numAlunos = 0;
                    
                        for(int i = 0 ; i < alunos.Length ; i++){
                            if(!string.IsNullOrEmpty(alunos[i].Nome)){
                            
                                notaTotal = notaTotal + alunos[i].Nota;
                                numAlunos ++;
                            }
                        }

                        var mediaGeral = (notaTotal / numAlunos);
                        Console.WriteLine($"Média Geral: {mediaGeral}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = VerificaOpcao();
            }

        }

        private static string VerificaOpcao(){
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Cadastrar novo aluno");
            Console.WriteLine("2 - Listar alunos cadastrados");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}