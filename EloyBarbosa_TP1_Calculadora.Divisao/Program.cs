using System;

namespace EloyBarbosa_TP1_Calculadora.Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eloy Barbosa TP1 Calculadora - Divisão");
            dividir();
        }
        public static void dividir()
        {
            Console.WriteLine("Entre com o primeiro Número");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Segundo Número");
            int segundoNumero = int.Parse(Console.ReadLine());

            try
            {
                int resultadoDivisao = primeiroNumero / segundoNumero;
                Console.WriteLine("O resultado da Divisão é:" + resultadoDivisao);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Você é Burro?! Não é possivel dividir por zero!!!");
                Console.WriteLine("Só me da trabalho, entre novamente com os numeros!!!");
                dividir();
            }
        }
    }
}
