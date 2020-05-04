using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eloy Barbosa TP1 Calculadora - Somar");
            somar();
        }
        public static void somar()
        {

            Console.WriteLine("Entre com o primeiro Número");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Segundo Número");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultadoSoma = primeiroNumero + segundoNumero;

            Console.WriteLine("O resultado da soma é:" + resultadoSoma);

        }

    }
}
