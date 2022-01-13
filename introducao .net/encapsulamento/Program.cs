using System;

namespace encapsulamento{

    class Program{

        static void Main(String[] args){

            Retangulo ret = new Retangulo();
            ret.defineMedida(-3, 5);
            ret.calcularArea();

            System.Console.WriteLine($"Area: {ret.calcularArea()}");
        }
    }
}