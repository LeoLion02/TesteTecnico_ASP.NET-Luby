using System;
using System.Linq;

namespace Vogais
{

    class Vogais
    {
        public static int CalcularVogais(string caractere)
        {
            int contador = 0;

            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

            contador = caractere.Count(x => vogais.Contains(x));

            return contador;
        }


        static void Main(string[] args)
        {

            string caractere = "Luby Software";
            caractere.ToLower();

            Console.WriteLine($"A sentança : {caractere}  ,possui {CalcularVogais(caractere)} vogais");

        }
    }
}
