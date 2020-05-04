using System;

namespace EloyBarbosa_TP1_Calculadora.subtracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eloy Barbosa TP1 Calculadora - Subtração");
            subtrair();
        }

        public static void subtrair()
        { 
           
            Console.WriteLine("Entre com o primeiro Número");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Segundo Número");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultadoSubtracao = primeiroNumero - segundoNumero;

            Console.WriteLine("O resultado da subtração é:" + resultadoSubtracao);
        }
    }
}
