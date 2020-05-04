using System;

namespace EloyBarbosa_TP1_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            menuPrincipal();
        }
        public static void menuPrincipal()
        {
            Console.WriteLine("Eloy Barbosa TP1 Calculadora");
            Console.WriteLine("Selecione uma operação");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("5 - Sair");

            string operacaoSelecionada = Console.ReadLine();


            if (operacaoSelecionada == "1")
            {
                somar();
            }
            else if (operacaoSelecionada == "2")
            {
                subtrair();
            }
            else if (operacaoSelecionada == "3")
            {
                dividir();
            }
            else if (operacaoSelecionada == "4")
            {
                multiplicar();
            }
            else if (operacaoSelecionada == "5")
            {
                Console.WriteLine("Até Logo");
            }
            else
            {
                Console.WriteLine("Favor inserir uma opção válida");
                menuPrincipal();
            }
        }

        public static void somar()
        {

            Console.WriteLine("Entre com o primeiro Número");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Segundo Número");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultadoSoma = primeiroNumero + segundoNumero;

            Console.WriteLine("O resultado da soma é:" + resultadoSoma);

            menuPrincipal();
        }

        public static void subtrair ()
        {
            Console.WriteLine("Entre com o primeiro Número");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Segundo Número");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultadoSubtracao = primeiroNumero - segundoNumero;

            Console.WriteLine("O resultado da subtração é:" + resultadoSubtracao);

            menuPrincipal();
        }

        public static void dividir ()
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
            catch(DivideByZeroException)
            {
                Console.WriteLine("Você é Burro?! Não é possivel dividir por zero!!!");
                Console.WriteLine("Só me da trabalho, entre novamente com os numeros!!!");
                dividir();
            }

            menuPrincipal();

        }

        public static void multiplicar()
        {

            Console.WriteLine("Entre com o primeiro Número");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o Segundo Número");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultadoMultiplicacao = primeiroNumero * segundoNumero;

            Console.WriteLine("O resultado da Multiplicação é:" + resultadoMultiplicacao);

            menuPrincipal();

        }


    }
}
