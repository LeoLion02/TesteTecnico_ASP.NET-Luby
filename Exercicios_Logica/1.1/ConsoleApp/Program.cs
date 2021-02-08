using System;

public class Program
{
    public static int CalcularFatorial(int number)
    {
        int cont;

        for (cont = 1; number > 1; number--)
        {
            cont *= number;

        }
        return cont;
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Digite um numero, para calcular o seu fatorial :");

        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CalcularFatorial(number));


    }
}