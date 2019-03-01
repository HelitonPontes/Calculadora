using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
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
          
           
        }
    }
}
