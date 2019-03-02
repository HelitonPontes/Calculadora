using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Calculadora calculadora = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumero1.Enabled = false;
            txtNumero2.Enabled = false;
            txtResultado.Enabled = false;
            btnSoma.Enabled = false;
            btnSubtrair.Enabled = false;
            btnDivisao.Enabled = false;
            btnMultiplicacao.Enabled = false;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNumero1.Enabled = true;
            txtNumero2.Enabled = true;
            txtResultado.Enabled = true;
            btnSoma.Enabled = true;
            btnSubtrair.Enabled = true;
            btnDivisao.Enabled = true;
            btnMultiplicacao.Enabled = true;

            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            calculadora.numero1 = int.Parse(txtNumero1.Text);
            calculadora.numero2 = int.Parse(txtNumero2.Text);
            txtResultado.Text = Convert.ToString(calculadora.numero1 + calculadora.numero2);
          
           
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            calculadora.numero1 = int.Parse(txtNumero1.Text);
            calculadora.numero2 = int.Parse(txtNumero2.Text);
            txtResultado.Text = Convert.ToString(calculadora.numero1 - calculadora.numero2);

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            calculadora.numero1 = int.Parse(txtNumero1.Text);
            calculadora.numero2 = int.Parse(txtNumero2.Text);
            txtResultado.Text = Convert.ToString(calculadora.numero1 * calculadora.numero2);


        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calculadora.numero1 = int.Parse(txtNumero1.Text);
            calculadora.numero2 = int.Parse(txtNumero2.Text);
            txtResultado.Text = Convert.ToString(calculadora.numero1 / calculadora.numero2);


        }
    }
}
