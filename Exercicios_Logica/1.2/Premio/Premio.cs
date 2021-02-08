using System;

public class Premio
{

    public static String CalcularPremio(double valor, string tipo, int quantidade)
    {

        switch (tipo)
        {

            case "basic":
                valor *= 1;
                break;

            case "vip":
                valor *= 1.2;
                break;

            case "premium":
                valor *= 1.5;
                break;

            case "deluxe":
                valor *= 1.8;
                break;

            case "special":
                valor *= 2;
                break;

        }
        valor *= quantidade;


        return $"{valor:0.00}";
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Digite o valor do premio :");
        double valor = Double.Parse(Console.ReadLine());

        while (valor <= 0)
        {
            Console.WriteLine("Erro no valor digitado! Tente novamente:");
            valor = Double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite o tipo do premio");
        string tipo = Console.ReadLine();

        Console.WriteLine("Digite a quantidade :");

        int quantidade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(CalcularPremio(valor, tipo, quantidade));

        //CalcularPremio(100, "vip", 1) == 120.00;//
        //CalcularPremio(100, "basic", 3) == 300.00;//
    }
}
