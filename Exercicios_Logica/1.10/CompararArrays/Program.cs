using System;

namespace CompararArrays
{
    class Program
    {
        public static void ObterElementosFaltantes(int[] vetor1, int[] vetor2)
        {

            Array.Sort(vetor1);
            Array.Sort(vetor2);

            int contador = 0;

            int maior = vetor1.Length > vetor2.Length ? vetor1.Length : vetor2.Length;
            int menor = vetor1.Length < vetor2.Length ? vetor1.Length : vetor2.Length;


            int[] Faltantes = new int[vetor1.Length + vetor2.Length];

            if (vetor1.Length > vetor2.Length)
            {

                for (int i = 0; i < menor; i++)
                {
                    if (Array.Exists(vetor1, value => value == vetor2[i]))
                        continue;

                    else
                    {
                        Faltantes[contador] = vetor2[i];
                        contador++;
                    }

                }

                for (int j = 0; j < maior; j++)
                {

                    if (Array.Exists(vetor2, value => value == vetor1[j]))
                        continue;

                    else
                    {
                        Faltantes[contador] = vetor1[j];
                        contador++;
                    }
                }


            }

            else
            {
                for (int i = 0; i < menor; i++)
                {
                    if (Array.Exists(vetor2, value => value == vetor1[i]))
                        continue;

                    else
                    {
                        Faltantes[contador] = vetor1[i];
                        contador++;
                    }

                }

                for (int j = 0; j < maior; j++)
                {

                    if (Array.Exists(vetor1, value => value == vetor2[j]))
                        continue;

                    else
                    {
                        Faltantes[contador] = vetor2[j];
                        contador++;
                    }
                }


            }


            int[] ResultadoFinal = new int[contador];
            int cont = 0;

            for (int k = 0; k < Faltantes.Length; k++)
            {

                if (Array.Exists(vetor1, value => value == Faltantes[k]) || Array.Exists(vetor2, value => value == Faltantes[k]))
                {
                    ResultadoFinal[cont] = Faltantes[k];
                    cont++;
                }
            }

            Console.Write("{ ");

            foreach (var values in ResultadoFinal)
            {
                Console.Write(values + ",");
            }

            Console.Write("}");

        }

        static void Main(string[] args)
        {
            int[] vetor1 = { 1, 2, 3, 4, 5 };
            int[] vetor2 = { 1, 2, 5 };
            ObterElementosFaltantes(vetor1, vetor2);

            int[] vetor3 = new int[] { 1, 4, 5 };
            int[] vetor4 = new int[] { 1, 2, 3, 4, 5 };
            ObterElementosFaltantes(vetor3, vetor4);


            int[] vetor5 = new int[] { 1, 2, 3, 4 };
            int[] vetor6 = new int[] { 2, 3, 4, 5 };
            ObterElementosFaltantes(vetor5, vetor6);


            int[] vetor7 = new int[] { 1, 3, 4, 5 };
            int[] vetor8 = new int[] { 1, 3, 4, 5 };
            ObterElementosFaltantes(vetor7, vetor8);
        }
    }
}

