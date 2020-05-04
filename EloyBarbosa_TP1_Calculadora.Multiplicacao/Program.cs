using System;

namespace EloyBarbosa_TP1_Calculadora.Multiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eloy Barbosa TP1 Calculadora - Multiplicação");
            multiplicar();
        }
        public static void multiplicar()
        {

            Console.WriteLine("Entre com o primeiro Número");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Segundo Número");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultadoMultiplicacao = primeiroNumero * segundoNumero;

            Console.WriteLine("O resultado da Multiplicação é:" + resultadoMultiplicacao);

        }
    }
}
