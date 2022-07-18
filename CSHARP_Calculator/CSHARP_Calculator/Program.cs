using System;

namespace CSHARP_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int contador;


            Console.WriteLine("Digite um número para ver sua tabuada");

            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Você escolheu o número " + valor + ", abaixo segue a tabuada o multiplicando por 1 a 10:");

            for (contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(valor + " x " + contador + " = " + valor * contador + "\n");
            }

            Console.WriteLine("Fim do programa");
            Console.Read();
        }
    }
}
