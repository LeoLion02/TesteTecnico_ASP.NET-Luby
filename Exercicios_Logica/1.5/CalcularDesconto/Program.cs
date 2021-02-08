using System;

namespace CalcularDesconto
{
    class Program
    {
        public static string CalcularValorComDescontoFormatado(string valor, string porcentagem)
        {

            valor = valor.Replace("R$", "").Replace(".", "").Trim();
            double Valor = Convert.ToDouble(valor);

            porcentagem = porcentagem.Replace("%", "").Trim();
            Double Porcentagem = Convert.ToDouble(porcentagem);

            Valor -= Valor * (Porcentagem / 100);


            return $"{Valor.ToString("C2")}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor :");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para porcentagem :");
            int porcentagem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalcularValorComDescontoFormatado($"R${valor:0.00}", $"{porcentagem.ToString()}%"));

            //Console.WriteLine(CalcularValorComDescontoFormatado("R$ 6.800,00", "30%"));
        }
    }
}
