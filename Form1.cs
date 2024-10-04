namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(Valor1.Text);
                double num2 = Convert.ToDouble(Valor2.Text);
                double resultado = num1 + num2;
                MessageBox.Show("Resultado: " + resultado.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(Valor1.Text);
                double num2 = Convert.ToDouble(Valor2.Text);
                double resultado = num1 - num2;
                MessageBox.Show("Resultado: " + resultado.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(Valor1.Text);
                double num2 = Convert.ToDouble(Valor2.Text);
                double resultado = num1 * num2;
                MessageBox.Show("Resultado: " + resultado.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(Valor1.Text);
                double num2 = Convert.ToDouble(Valor2.Text);

                if (num2 == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero.");
                }
                else
                {
                    double resultado = num1 / num2;
                    MessageBox.Show("Resultado: " + resultado.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
