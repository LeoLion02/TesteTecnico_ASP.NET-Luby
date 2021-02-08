using System;

namespace Matriz
{
    class Transformar
    {
        public static void TransformarEmMatriz(string name)
        {
            int contador = 0;

            string[] names = name.Split(',');
            int[][] matriz = new int[names.Length / 2][];
            int[] totalidade = Array.ConvertAll(names, int.Parse);

            for (int h = 0; h < names.Length / 2; h++)
            {
                matriz[h] = new int[2];
            }

            for (int i = 0; i < names.Length / 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    matriz[i].SetValue(totalidade[contador], j);
                    j++;
                    contador++;
                    matriz[i].SetValue(totalidade[contador], j);
                    contador++;

                    if (contador > totalidade.Length)
                        break;
                }
            }

            for (int m = 0; m < names.Length / 2; m++)
            {
                Console.Write(matriz[m] + "= { ");
                foreach (var elements in matriz[m])
                {
                    Console.Write(elements + ",");

                }
                Console.Write("}");
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {

            TransformarEmMatriz("1,2,3,4,5,6");
            Console.WriteLine();
            TransformarEmMatriz("1,2,3,4,5,6,7,8");

        }
    }
}
