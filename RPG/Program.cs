using dotnet__poo.src.Entities;

namespace dotnet__poo
{

    class Program
    {

        static void Main(String[] args)
        {

            Arus hero = new Arus("Malik", 21, "Magic");

            Console.Write(hero); //automaticamente usa o ToString
        }
    }
}
