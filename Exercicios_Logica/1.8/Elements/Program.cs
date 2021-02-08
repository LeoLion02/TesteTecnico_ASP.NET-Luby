using System;
using System.Collections;

namespace Elements
{
    class Program
    {
        public static void BuscarPessoa(string[] vetor, string pessoa)
        {

            ArrayList Resultado = new ArrayList();


            for (int i = 0; i < vetor.Length; i++)
            {

                if (vetor[i].Contains(pessoa))
                    Resultado.Add(vetor[i]);
            }

            foreach (var names in Resultado)
            {
                Console.WriteLine(names);
            }
        }

        static void Main(string[] args)
        {
            string[] vetor = new string[] {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero" };

            BuscarPessoa(vetor, "Doe");
            BuscarPessoa(vetor, "Alice");
            BuscarPessoa(vetor, "Louis");

        }
    }
}
