using System;

namespace DiferencaDIas
{
    class Dias
    {

        public static void CalcularDiferencaData(string DataInicial, string DataFinal)
        {

            string NovaDataInicial = DataInicial.Insert(2, "-").Insert(5, "-");
            string NovaDataFinal = DataFinal.Insert(2, "-").Insert(5, "-");

            TimeSpan Diferenca = Convert.ToDateTime(NovaDataFinal) - Convert.ToDateTime(NovaDataInicial);


            Console.WriteLine($"{Diferenca.Days}");
        }

        static void Main(string[] args)
        {
            CalcularDiferencaData("10122020", "25122020");
        }
    }
}
