using dotnet__poo.src.Entities;

namespace dotnet__poo
{

    class Program
    {

        static void Main(String[] args)
        {

            Person hero = new Person("Malik", 21, "Knight");
            Wizard wizard = new Wizard("Jenne", 17, "Magic");

            Console.WriteLine(hero.Attack()); //automaticamente usa o ToString
            Console.WriteLine(wizard.Attack());
        }
    }
}
