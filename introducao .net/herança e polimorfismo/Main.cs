namespace herança{
    public class Principal{
        
        static void Main(string[] args){

            Aluno a1 = new Aluno();
            a1.Nome = "Paulo";
            a1.Idade = 21;
            a1.Nota = 7;
            a1.Apresentar();

            Professor p1 = new Professor();
            p1.Nome = "Pedro";
            p1.Idade = 32;
            p1.Salario = 3500;
            p1.Apresentar();
        }
    }
}