namespace herança{
    public class Professor : Pessoa{
        public int Salario { get; set;}

        public override void Apresentar(){
            System.Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e ganho um sálario de {Salario} reais");
        }
    }
}