using System;
using System.Collections;

namespace VetorPares
{
    class ParidadeVetor
    {
        public static void ObterElementosPares(int[] vetor)
        {

            ArrayList Pares = new ArrayList();

            for (int i = 0; i < vetor.Length; i++)
            {

                if (vetor[i] % 2 == 0)
                    Pares.Add(vetor[i]);

            }


            foreach (var number in Pares)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5 };

            ObterElementosPares(vetor);

        }
    }
}
