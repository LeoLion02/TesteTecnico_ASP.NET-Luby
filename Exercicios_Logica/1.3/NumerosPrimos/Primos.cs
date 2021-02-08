using System;

namespace NumerosPrimos
{
    class Primos
    {

        public static Boolean VerificarPrimo(int number)
        {
            int multiplo = 0;

            for (int contador = 2; contador < number; contador++)
            {
                if (number % contador == 0)
                    multiplo += 1;
            }

            if (multiplo == 0)
                return true;

            else
                return false;
        }

        public static int ContarNumeroPrimo(int number)
        {

            int primos = 0;

            for (int i = 2; i < number; i++)
            {
                if (VerificarPrimo(i))
                    primos++;
            }

            return primos;

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero :");
            int number = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"O numero total de numeros primos antes de {number} e igual a : {ContarNumeroPrimo(number)}");

            //Console.WriteLine(ContarNumerosPrimos(10));
        }
    }
}
