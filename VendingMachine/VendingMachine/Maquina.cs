using System.Windows.Forms;

namespace VendingMachine
{
    class Maquina : Usuario
    {
        public int CocaCola { set; get; } = 10;
        public int Pepsi { set; get; } = 10;
        public int Sprite { set; get; } = 10;
        public int Guarana { set; get; } = 10;
        public int Fanta { set; get; } = 10;
        public int Agua { set; get; } = 10;

        public void AddMoney(double dinheiro)
        {
            Dinheiro += dinheiro;
            DinheiroDisponivel();
        }

        public string DinheiroDisponivel()
        {
            return $"Dinheiro Disponivel : {Dinheiro:C2}";
        }


        public string MostrarEstoque()
        {
            return $"CocaCola: {CocaCola}, \n Pepsi: {Pepsi}, \n Sprite: {Sprite}, \n Guarana: {Guarana}, \n Fanta: {Fanta}, \n Agua: {Agua}";
        }

        public void ComprarBebida(int number, int quantidade)
        {
            switch (number)
            {
                case 0:
                    if (Dinheiro < 2.50 * quantidade) { MessageBox.Show($"Dinheiro Insuficiente! Voce precisa de : {2.50 * quantidade - Dinheiro:C2}"); break; }
                    if (CocaCola == 0) { MessageBox.Show("Estoque Insuficiente"); break; }
                    Dinheiro -= 2.50 * quantidade;
                    CocaCola -= quantidade;
                    cocaComprada += quantidade;
                    break;
                case 1:
                    if (Dinheiro < 2.25 * quantidade) { MessageBox.Show($"Dinheiro Insuficiente! Voce precisa de : {2.25 * quantidade - Dinheiro:C2}"); break; }
                    if (Pepsi == 0) { MessageBox.Show("Estoque Insuficiente"); break; }
                    Dinheiro -= 2.25 * quantidade;
                    Pepsi -= quantidade;
                    pepsiComprada += quantidade;
                    break;
                case 2:
                    if (Dinheiro < 2.10 * quantidade) { MessageBox.Show($"Dinheiro Insuficiente! Voce precisa de : {2.10 * quantidade - Dinheiro:C2}"); break; }
                    if (Sprite == 0) { MessageBox.Show("Estoque Insuficiente"); break; }
                    Dinheiro -= 2.10 * quantidade;
                    Sprite -= quantidade;
                    spriteComprada += quantidade;

                    break;
                case 3:
                    if (Dinheiro < 2.40 * quantidade) {MessageBox.Show($"Dinheiro Insuficiente! Voce precisa de : {2.40 * quantidade - Dinheiro:C2}"); break; }
                    if (Guarana == 0) { MessageBox.Show("Estoque Insuficiente"); break; }
                    Dinheiro -= 2.40 * quantidade;
                    Guarana -= quantidade;
                    guaranaComprada += quantidade;
                    break;
                case 4:
                    if (Dinheiro < 2.45 * quantidade) { MessageBox.Show($"Dinheiro Insuficiente! Voce precisa de : {2.45 * quantidade- Dinheiro:C2}"); break; }
                    if (Fanta == 0) { MessageBox.Show("Estoque Insuficiente"); break; }
                    Dinheiro -= 2.45 * quantidade;
                    Fanta -= quantidade;
                    fantaComprada += quantidade;
                    break;
                case 5:
                    if (Dinheiro < 1.50 * quantidade) { MessageBox.Show($"Dinheiro Insuficiente! Voce precisa de : {1.50 * quantidade - Dinheiro:C2}"); break; }
                    if (Agua == 0) { MessageBox.Show("Estoque Insuficiente"); break; }
                    Dinheiro -= 1.50 * quantidade;
                    Agua -= quantidade;
                    aguaComprada += quantidade;
                    break;

            }
        }

        public string Comprada0()
        {

            return $"Comprada: {cocaComprada}";
        }

        public string Comprada1()
        {
            return $"Comprada: {pepsiComprada}";
        }


        public string Comprada2()
        {
            return $"Comprada: {spriteComprada}";
        }

        public string Comprada3()
        {

            return $"Comprada: {guaranaComprada}";
        }

        public string Comprada4()
        {

            return $"Comprada: {fantaComprada}";
        }

        public string Comprada5()
        {

            return $"Comprada: {aguaComprada}";
        }

    }


}

