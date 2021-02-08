using System;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        Usuario user = new Usuario();
        Maquina machine = new Maquina();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valor = textBox2.Text;

            double real = Convert.ToDouble(valor);

            machine.AddMoney(real);

            textBox9.Text = machine.DinheiroDisponivel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numbers = textBox1.Text;

            int seletor = Int32.Parse(numbers);

            string quantity = textBox10.Text;

            int Quantidade = Convert.ToInt32(quantity);

            machine.ComprarBebida(seletor, Quantidade);

            textBox9.Text = machine.DinheiroDisponivel();

            textBox11.Text = machine.Comprada0();
            textBox12.Text = machine.Comprada4();
            textBox13.Text = machine.Comprada2();
            textBox14.Text = machine.Comprada3();
            textBox15.Text = machine.Comprada1();
            textBox16.Text = machine.Comprada5();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-5]"))
            {
                MessageBox.Show("Apenas Numeros até 5");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(machine.MostrarEstoque());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Apenas Numeros até 5");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
