using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAula14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int count = 0;
        Random random = new Random();

        private void label2_Click(object sender, EventArgs e)
        {

        }
       

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int campoNumero = int.Parse(txtNumero.Text);
            //int campoNumeroAleatório = int.Parse(txtNumeroAleatorio.Text);
            int campoNumeroAleatório = random.Next(11);
            txtNumeroAleatorio.Text = campoNumeroAleatório.ToString();

            int resultado = campoNumero + campoNumeroAleatório;

            lblResultado.Text = $"Resultado: {resultado}";

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNumeroAleatorio_TextChanged(object sender, EventArgs e)
        {
            txtNumeroAleatorio.Enabled = false;
            Random random = new Random();
           // txtNumeroAleatorio.Text = random.Next(11);
            

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int campoNumero = int.Parse(txtNumero.Text);
           // int campoNumeroAleatório = int.Parse(txtNumeroAleatorio.Text);

            int campoNumeroAleatório = random.Next(11);
            txtNumeroAleatorio.Text = campoNumeroAleatório.ToString();

            int resultado = campoNumero - campoNumeroAleatório;

            lblResultado.Text = $"Resultado: {resultado}";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int campoNumero = int.Parse(txtNumero.Text);
            //int campoNumeroAleatório = int.Parse(txtNumeroAleatorio.Text);
            int campoNumeroAleatório = random.Next(11);
            txtNumeroAleatorio.Text = campoNumeroAleatório.ToString();
            int resultado = campoNumero / campoNumeroAleatório;

            lblResultado.Text = $"Resultado: {resultado}";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int campoNumero = int.Parse(txtNumero.Text);
            //int campoNumeroAleatório = int.Parse(txtNumeroAleatorio.Text);
            int campoNumeroAleatório = random.Next(11);
            txtNumeroAleatorio.Text = campoNumeroAleatório.ToString();
            int resultado = campoNumero * campoNumeroAleatório;

            lblResultado.Text = $"Resultado: {resultado}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
